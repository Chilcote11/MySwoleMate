using MySwoleMate.BLL;
using System;
using System.Configuration;
using System.Web.UI.WebControls;

namespace MySwoleMate
{
    public partial class Workouts : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString();
        //string connectionString = ConfigurationManager.ConnectionStrings["Data Source=DESKTOP-T5AJ151\\SQLEXPRESS;Initial Catalog=MySwoleMate;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }
        protected void WorkoutList_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int workoutID = Convert.ToInt32(WorkoutList.DataKeys[e.RowIndex].Value.ToString());
            WorkoutBLL bll = new WorkoutBLL(connectionString);
            bll.DeleteWorkout(workoutID);
            BindData();
        }

        private void BindData()
        {
            WorkoutBLL workout = new WorkoutBLL(connectionString);
            WorkoutList.DataSource = workout.GetAllWorkouts();
            WorkoutList.DataBind();
        }
    }
}