using MySwoleMate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySwoleMate.DAL
{
    public class MeasurementDAL
    {
        public MeasurementDAL()
        {
            // need connection string here?  ... don't think so
        }
        public List<Measurement> GetAllMeasurements()
        {
            List<Measurement> measurements = new List<Measurement>();
            using (MySwoleMateEntities db = new MySwoleMateEntities())
            {
                measurements = db.Measurements.ToList();
            }
            return measurements;
        }

        public Measurement GetMeasurementById(int id)
        {
            List<Measurement> measurements = GetAllMeasurements(); // could make a new query.. or just do this
            Measurement measurement = new Measurement();
            foreach (Measurement m in measurements)
            {
                if (m.MeasurementID == id)
                    measurement = m;
            }
            return measurement;
        }

        public void AddMeasurement(Measurement measurement)
        {
            using (MySwoleMateEntities db = new MySwoleMateEntities())
            {
                db.Measurements.Add(measurement);
                db.SaveChanges();
            }
        }

        public void EditMeasurement(Measurement measurement)
        {
            using (MySwoleMateEntities db = new MySwoleMateEntities())
            {
                db.Entry(measurement).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteMeasurement(Measurement measurement)
        {
            using (MySwoleMateEntities db = new MySwoleMateEntities())
            {
                db.Entry(measurement).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}
