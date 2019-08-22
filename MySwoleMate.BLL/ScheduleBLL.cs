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
            List<Schedule> schedules = data.GetAllSchedules();
            foreach(Schedule s in schedules)
            {
                s.DisplayScheduleDtTime = DtTimeDisplay(s.ScheduleDtTime);
                s.DisplayInputDtTime = DtTimeDisplay(s.InputDtTime);
            }
            return schedules;
        }

        public Schedule GetScheduleById(int id)
        {
            return data.GetScheduleById(id);
            // TODO use display methods here?  Never do in other BLLs
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

        public string DtTimeDisplay(System.DateTime dateTime)
        {
            return dateTime.ToShortDateString();
        }
    }
}
