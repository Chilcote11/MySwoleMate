using MySwoleMate.DAL;
using MySwoleMate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySwoleMate.BLL
{
    public class MeasurementBLL
    {
        private MeasurementDAL data;

        public MeasurementBLL()
        {
            data = new MeasurementDAL();
        }

        public List<Measurement> GetAllMeasurements()
        {
            return data.GetAllMeasurements();
        }

        public Measurement GetMeasurementById(int id)
        {
            return data.GetMeasurementById(id);
        }

        public void AddMeasurement(Measurement measurement)
        {
            data.AddMeasurement(measurement);
        }

        public void EditMeasurement(Measurement measurement)
        {
            data.EditMeasurement(measurement);
        }

        public void DeleteMeasurement(Measurement measurement)
        {
            data.DeleteMeasurement(measurement);
        }

        // TODO: create any display formatting methods?
    }
}
