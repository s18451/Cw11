using Cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw11.Data
{
    public class MedicamentData : IEntityTypeConfiguration<Medicament>
    {
        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            var data = new List<Medicament>();
            data.Add(new Medicament() { Description = "insomnia", IdMedicament = 1, Name = "Insom", Type = "drops" });
            data.Add(new Medicament() { Description = "headache", IdMedicament = 2, Name = "Headless", Type = "capsule" });
            data.Add(new Medicament() { Description = "stomachache", IdMedicament = 3, Name = "Mylanta", Type = "liquid" });

            builder.HasData(data);
        }
    }
}
