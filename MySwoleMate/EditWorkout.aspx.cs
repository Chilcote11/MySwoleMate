﻿using MySwoleMate.BLL;
using MySwoleMate.Models;
using System;
using System.Configuration;
using System.Web.UI;

namespace MySwoleMate
{
    public partial class EditWorkout : System.Web.UI.Page
    {
        //Create a new instance of the business logic class for Trainees, we created the instance
        //here so that we can use it with both the Page_Load and Click event for TraineeEditButton
        WorkoutBLL bll = new WorkoutBLL(ConfigurationManager.ConnectionStrings["MySwoleMateConnectionString"].ToString());

        /// <summary>
        /// Add Workout to DB from user input form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            //Only load the values if the request is not a PostBack
            if (!IsPostBack)
            {
                //We pass the WorkoutID by a Query String from the GridView on Workouts.aspx. See how we passed 
                //WorkoutID to this page from Workouts.aspx by looking at HyperLinkField in the GridView control
                //on the Workouts.aspx page for clarification
                WorkoutViewModel workout = bll.GetWorkoutById(Convert.ToInt32(Request.QueryString["WorkoutID"]));
                //We use the GetWorkoutById method to get the Workout from the database, which we use to 
                //populate the data into the form.
                WorkoutName.Text = workout.WorkoutName;
                Exercise1.Text = workout.Exercise1;
                Exercise1Sets.Text = workout.Exercise1Sets.ToString();
                Exercise1Reps.Text = workout.Exercise1Reps.ToString();
                Exercise2.Text = workout.Exercise2;
                Exercise2Sets.Text = workout.Exercise2Sets.ToString();
                Exercise2Reps.Text = workout.Exercise2Reps.ToString();
                Exercise3.Text = workout.Exercise3;
                Exercise3Sets.Text = workout.Exercise3Sets.ToString();
                Exercise3Reps.Text = workout.Exercise3Reps.ToString();
                Exercise4.Text = workout.Exercise4;
                Exercise4Sets.Text = workout.Exercise4Sets.ToString();
                Exercise4Reps.Text = workout.Exercise4Reps.ToString();
                Exercise5.Text = workout.Exercise5;
                Exercise5Sets.Text = workout.Exercise5Sets.ToString();
                Exercise5Reps.Text = workout.Exercise5Reps.ToString();
            }
        }

        protected void WorkoutEditButton_Click(object sender, EventArgs e)
        {
            //Checks to see if all Validation Controls are valid
            if (Page.IsValid)
            {
                //Create new empty ViewModel to pass in the new values
                WorkoutViewModel workout = new WorkoutViewModel();
                //Use the same query string to fill the ID
                workout.WorkoutID = Convert.ToInt32(Request.QueryString["WorkoutID"]);
                workout.WorkoutName = WorkoutName.Text;
                workout.Exercise1 = Exercise1.Text;
                workout.Exercise2 = Exercise2.Text;
                workout.Exercise3 = Exercise3.Text;
                workout.Exercise4 = Exercise4.Text;
                workout.Exercise5 = Exercise5.Text;
                //Since the Text property returns a string, some properties would need to be converted
                workout.Exercise1Sets = Convert.ToInt32(Exercise1Sets.Text);
                workout.Exercise1Reps = Convert.ToInt32(Exercise1Reps.Text);
                workout.Exercise2Sets = Convert.ToInt32(Exercise2Sets.Text);
                workout.Exercise2Reps = Convert.ToInt32(Exercise2Reps.Text);
                workout.Exercise3Sets = Convert.ToInt32(Exercise3Sets.Text);
                workout.Exercise3Reps = Convert.ToInt32(Exercise3Reps.Text);
                workout.Exercise4Sets = Convert.ToInt32(Exercise4Sets.Text);
                workout.Exercise4Reps = Convert.ToInt32(Exercise4Reps.Text);
                workout.Exercise5Sets = Convert.ToInt32(Exercise5Sets.Text);
                workout.Exercise5Reps = Convert.ToInt32(Exercise5Reps.Text);
                //Call the EditWorkout() method passing in the new values
                bll.EditWorkout(workout);
                //Redirect to the Workouts.aspx page
                Response.Redirect("~/Workouts.aspx");
            }
        }
    }
}