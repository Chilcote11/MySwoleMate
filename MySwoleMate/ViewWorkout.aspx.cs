using MySwoleMate.BLL;
using MySwoleMate.Models;
using System;
using System.Configuration;

namespace MySwoleMate
{
    public partial class ViewWorkout : System.Web.UI.Page
    {
        TraineeBLL trainee_BLL = new TraineeBLL(ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString());
        WorkoutBLL workout_BLL = new WorkoutBLL(ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString());

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TraineeViewModel trainee = trainee_BLL.GetTraineeById(Convert.ToInt32(Request.QueryString["TraineeID"]));

                TraineeNameLabel.Text = trainee.FirstName + " " + trainee.LastName;

                if (trainee.WorkoutID != 0)
                {
                    WorkoutViewModel workout = workout_BLL.GetWorkoutById(trainee.WorkoutID);

                    WorkoutNameLabel.Text = workout.WorkoutName;
                    Exercise1Label.Text = workout.DisplayExercise1;
                    Exercise2Label.Text = workout.DisplayExercise2;
                    Exercise3Label.Text = workout.DisplayExercise3;
                    Exercise4Label.Text = workout.DisplayExercise4;
                    Exercise5Label.Text = workout.DisplayExercise5;

                }
                else
                {
                    NoWorkoutLabel.Text = "There is no Workout Assigned to: ";
                }
            }
        }

        protected void AssignWorkoutButton_Click(object sender, EventArgs e)
        {
            String traineeID = trainee_BLL.GetTraineeById(Convert.ToInt32(Request.QueryString["TraineeID"])).TraineeID.ToString();
            Response.Redirect("~/AssignWorkout.aspx?TraineeID=" + traineeID);
            //Response.Redirect("~/AssignWorkout.aspx?TraineeID={0}");
        }
    }
}