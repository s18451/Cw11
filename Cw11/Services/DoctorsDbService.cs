using Cw11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw11.Services
{
    public class DoctorsDbService : IDoctorsDbService
    {
        private readonly CodeFirstContext context;

        public DoctorsDbService(CodeFirstContext _context)
        {
            context = _context;
        }

        public IEnumerable<Doctor> GetDoctorsList()
        {
            return context.Doctor.ToList();
        }

        public IEnumerable<Doctor> GetDoctor(int id)
        {
            var res = context.Doctor.Where(doctor => doctor.IdDoctor == id).ToList();
            return res;
        }

        public string AddDoctor(Doctor doctor)
        {
            context.Add(doctor);
            context.SaveChangesAsync();
            return "Adding complete";
        }

        public string UpdateDoctor(int id, Doctor doctor)
        {
            doctor.IdDoctor = id;
            context.Attach(doctor);
            context.Entry(doctor).Property("FirstName").IsModified = true;
            context.Entry(doctor).Property("LastName").IsModified = true;
            context.Entry(doctor).Property("Email").IsModified = true;
            context.SaveChangesAsync();
            return "Update successful";
        }

        public string DeleteDoctor(int id)
        {
            var d = new Doctor() { IdDoctor = id };
            context.Attach(d);
            context.Remove(d);
            context.SaveChangesAsync();

            return "Delete successful";
        }
    }
}
