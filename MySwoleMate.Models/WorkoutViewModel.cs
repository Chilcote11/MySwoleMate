using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySwoleMate.Models
{
    public class WorkoutViewModel
    {
        public int WorkoutID { get; set; }
        public string WorkoutName { get; set; }
        public string Exercise1 { get; set; }
        public int Exercise1Reps { get; set; }
        public int Exercise1Sets { get; set; }
        public string Exercise2 { get; set; }
        public int Exercise2Reps { get; set; }
        public int Exercise2Sets { get; set; }
        public string Exercise3 { get; set; }
        public int Exercise3Reps { get; set; }
        public int Exercise3Sets { get; set; }
        public string Exercise4 { get; set; }
        public int Exercise4Reps { get; set; }
        public int Exercise4Sets { get; set; }
        public string Exercise5 { get; set; }
        public int Exercise5Reps { get; set; }
        public int Exercise5Sets { get; set; }
        public string DisplayExercise1
        {
            get
            {
                return this.Exercise1 + ": " + this.Exercise1Sets + "x" + this.Exercise1Reps;
            }
            set { }
        }
        public string DisplayExercise2
        {
            get
            {
                return this.Exercise2 + ": " + this.Exercise2Sets + "x" + this.Exercise2Reps;
            }
            set { }
        }
        public string DisplayExercise3
        {
            get
            {
                return this.Exercise3 + ": " + this.Exercise3Sets + "x" + this.Exercise3Reps;
            }
            set { }
        }
        public string DisplayExercise4
        {
            get
            {
                return this.Exercise4 + ": " + this.Exercise4Sets + "x" + this.Exercise4Reps;
            }
            set { }
        }
        public string DisplayExercise5
        {
            get
            {
                return this.Exercise5 + ": " + this.Exercise5Sets + "x" + this.Exercise5Reps;
            }
            set { }
        }

    }
        
}
