using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySwoleMate.Models
{
    public partial class Schedule
    {
        public string DisplayScheduleDtTime
        {
            get
            {
                return this.ScheduleDtTime.ToShortDateString();
            }
            set { }
        }

        public string DisplayInputDtTime
        {
            get
            {
                return this.InputDtTime.ToShortDateString();
            }
            set { }
        }
    }
}
