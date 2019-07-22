using MySwoleMate.BLL;
using MySwoleMate.Models;
using System;
using System.Configuration;
using System.Web.UI;

namespace MySwoleMate
{
    public partial class AssignWorkout : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString();
        WorkoutBLL workout_BLL = new WorkoutBLL(ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString());
        TraineeBLL trainee_BLL = new TraineeBLL(ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TraineeViewModel trainee = trainee_BLL.GetTraineeById(Convert.ToInt32(Request.QueryString["TraineeID"]));
                TraineeNameLabel.Text = trainee.FirstName + " " + trainee.LastName;

                ddlWorkouts.DataSource = workout_BLL.GetAllWorkouts();
                ddlWorkouts.DataTextField = "WorkoutName";
                ddlWorkouts.DataValueField = "WorkoutID";       // not sure if I need this line
                ddlWorkouts.DataBind();

            }
        }

        protected void AssignWorkoutButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                // this line prints an integer successfully
                WorkoutViewModel workout = workout_BLL.GetWorkoutById(Convert.ToInt32(ddlWorkouts.SelectedValue));
                TraineeViewModel trainee = trainee_BLL.GetTraineeById(Convert.ToInt32(Request.QueryString["TraineeID"]));
                trainee.WorkoutID = workout.WorkoutID;


                trainee_BLL.EditTrainee(trainee);

                Response.Redirect("~/Trainees.aspx");
            }
        }
    }
}