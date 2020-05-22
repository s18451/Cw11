using Cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw11.Data
{
    public class PrescriptionData : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            var data = new List<Prescription>();

            data.Add(new Prescription()
            {
                Date = Convert.ToDateTime("2020-03-03"),
                DueDate = Convert.ToDateTime("2020-03-14"),
                IdDoctor = 1,
                IdPatient = 1,
                IdPrescription = 1
            });

            data.Add(new Prescription()
            {
                Date = Convert.ToDateTime("2020-02-15"),
                DueDate = Convert.ToDateTime("2020-3-24"),
                IdDoctor = 2,
                IdPatient = 2,
                IdPrescription = 2
            });

            data.Add(new Prescription()
            {
                Date = Convert.ToDateTime("2020-03-12"),
                DueDate = Convert.ToDateTime("2020-04-11"),
                IdDoctor = 3,
                IdPatient = 3,
                IdPrescription = 3
            });

            builder.HasData(data);
        }
    }
}
