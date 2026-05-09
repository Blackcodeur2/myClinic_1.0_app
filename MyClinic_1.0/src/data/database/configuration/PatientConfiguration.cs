using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyClinic_1._0.src.data.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClinic_1._0.src.data.database.configuration
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.ToTable("patients");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nom)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Prenom)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Telephone)
                .IsRequired()
                .HasMaxLength(20);

            builder.HasIndex(p => p.Telephone)
                .IsUnique();
        }
    }
}
