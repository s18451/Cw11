using Cw11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw11.Data
{
    public class PrescriptionMedicamentData : IEntityTypeConfiguration<PrescriptionMedicament>
    {
        public void Configure(EntityTypeBuilder<PrescriptionMedicament> builder)
        {
            var data = new List<PrescriptionMedicament>();

            data.Add(new PrescriptionMedicament { Details = "On an empty stomach", Dose = 3, IdMedicament = 1, IdPrescription = 1 });
            data.Add(new PrescriptionMedicament { Details = "Before 7pm", Dose = 5, IdMedicament = 2, IdPrescription = 2 });
            data.Add(new PrescriptionMedicament { Details = "Before dinner", Dose = 10, IdMedicament = 3, IdPrescription = 3 });

            builder.HasData(data);
        }
    }
}
