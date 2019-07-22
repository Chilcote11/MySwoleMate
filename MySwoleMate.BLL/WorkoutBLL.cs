using MySwoleMate.DAL;
using MySwoleMate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySwoleMate.BLL
{
    public class WorkoutBLL
    {
        //Instance of the Data Access Layer class for Workout
        private WorkoutDAL data;

        // Constructor that accepts a connectionString from the Presentation Layer,
        // Use the connectionString to pass into a new instance of the Data Access Layer class
        // WorkoutDAL
        public WorkoutBLL(string connectionString)
        {
            data = new WorkoutDAL (connectionString);
        }

        // Gets all Workouts in a List of WorkoutViewModel
        public List<WorkoutViewModel> GetAllWorkouts()
        {
            //return the List<WorkoutViewModel> from WorkoutDAL
            List<WorkoutViewModel> workouts = data.GetWorkouts();
            foreach(var item in workouts)
            {
                //item.DisplayWorkoutName = WorkoutNameDisplay(item.WorkoutName);
                item.DisplayExercise1 = ExerciseDisplay(item.Exercise1, item.Exercise1Reps, item.Exercise1Sets);
                item.DisplayExercise2 = ExerciseDisplay(item.Exercise2, item.Exercise2Reps, item.Exercise2Sets);
                item.DisplayExercise3 = ExerciseDisplay(item.Exercise3, item.Exercise3Reps, item.Exercise3Sets);
                item.DisplayExercise4 = ExerciseDisplay(item.Exercise4, item.Exercise4Reps, item.Exercise4Sets);
                item.DisplayExercise5 = ExerciseDisplay(item.Exercise5, item.Exercise5Reps, item.Exercise5Sets);
            }
            return workouts;
        }

        // Returns ViewModel of Workout by the ID
        public WorkoutViewModel GetWorkoutById(int id)
        {
            return data.GetWorkoutById(id);
        }

        // Edits the Workout accepting a WorkoutViewModel
        public int EditWorkout(WorkoutViewModel edit)
        {
            return data.EditWorkout(edit);
        }

        // Adds a new Workout
        public int AddWorkout(WorkoutViewModel add)
        {
            return data.AddWorkout(add);
        }

        // Deletes a workout by the Id, Delete only needs the id of Workout
        public int DeleteWorkout(int id)
        {
            return data.DeleteWorkout(id);
        }

        // create Exercise Display below
        private string ExerciseDisplay(string exercise, int reps, int sets)
        {
            return exercise + " " + reps + " x " + sets;

        }
    }
}
