using Cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw11.Data
{
    public class DoctorData : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            var data = new List<Doctor>();
            data.Add(new Doctor() { Email = "mail1@test.pl", FirstName = "Adam", LastName = "Małysz", IdDoctor = 1 });
            data.Add(new Doctor() { Email = "mail2@test.pl", FirstName = "Jan", LastName = "Kowalski", IdDoctor = 2 });
            data.Add(new Doctor() { Email = "mail3@test.pl", FirstName = "Karol", LastName = "Nowak", IdDoctor = 3 });

            builder.HasData(data);
        }
    }
}
