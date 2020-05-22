using Cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw11.Data
{
    public class PatientData : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            var data = new List<Patient>();

            data.Add(new Patient() { BirthDate = Convert.ToDateTime("1990-04-12"), FirstName = "Jan", LastName = "Kowalski", IdPatient = 1 });
            data.Add(new Patient() { BirthDate = Convert.ToDateTime("1993-01-02"), FirstName = "Adam", LastName = "Małysz", IdPatient = 2 });
            data.Add(new Patient() { BirthDate = Convert.ToDateTime("1983-05-11"), FirstName = "Robert", LastName = "Kubica", IdPatient = 3 }); ;

            builder.HasData(data);
        }
    }
}
