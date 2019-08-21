using MySwoleMate.DAL;
using MySwoleMate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySwoleMate.BLL
{
    public class ScheduleBLL
    {
        private ScheduleDAL data;

        public ScheduleBLL()
        {
            data = new ScheduleDAL();
        }

        public List<Schedule> getAllSchedules()
        {
            return data.GetAllSchedules();
        }

        public Schedule GetScheduleById(int id)
        {
            return data.GetScheduleById(id);
        }

        public void AddSchedule(Schedule schedule)
        {
            data.AddSchedule(schedule);
        }

        public void EditSchedule(Schedule schedule)
        {
            data.EditSchedule(schedule);
        }

        public void DeleteSchedule(Schedule schedule)
        {
            data.DeleteSchedule(schedule);
        }

        // TODO: create any display formatting methods?
    }
}
