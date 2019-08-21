using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySwoleMate.Models;
using System.Web;
using System.Data.Entity;

namespace MySwoleMate.DAL
{
    public class ScheduleDAL
    {
        public ScheduleDAL()
        {
            // need connection string here?
        }

        // Returs All Schedules.
        public List<Schedule> GetAllSchedules()
        {
            List<Schedule> schedules = new List<Schedule>();
            using (MySwoleMateEntities db = new MySwoleMateEntities())
            {
                schedules = db.Schedules.ToList();
            }
            return schedules;
        }

        public Schedule GetScheduleById(int id)
        {
            List<Schedule> schedules = GetAllSchedules(); // could make a new query.. or just do this
            Schedule schedule = new Schedule();
            foreach (Schedule s in schedules) {
                if (s.ScheduleID == id)
                    schedule = s;
            }
            return schedule;
        }

        public void AddSchedule(Schedule schedule)
        {
            using (MySwoleMateEntities db = new MySwoleMateEntities())
            {
                db.Schedule.Add(schedule);
                db.SaveChanges();
            }
        }

        public void EditSchedule(Schedule schedule)
        {
            using (MySwoleMateEntities db = new MySwoleMateEntities())
            {
                db.Entry(schedule).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteSchedule(Schedule schedule)
        {
            using (MySwoleMateEntities db = new MySwoleMateEntities())
            {
                db.Entry(schedule).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}
