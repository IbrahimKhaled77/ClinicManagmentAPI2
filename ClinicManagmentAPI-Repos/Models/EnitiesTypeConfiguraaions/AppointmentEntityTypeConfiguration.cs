﻿using ClinicManagmentAPI_Repos.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicManagmentAPI_Repos.Models.EnitiesTypeConfiguraaions
{
    public class AppointmentEntityTypeConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            //shared entity configuration
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CreationDate).IsRequired();
            
            builder.Property(x => x.CreatorUser).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired(false);
            builder.Property(x => x.ModifiedUser).IsRequired(false);
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            //Entity Config
            builder.Property(x => x.Description).IsRequired(false);
            builder.ToTable(t => t.HasCheckConstraint("CH_Appointment_Date", "Date >= GetDate()"));
            //relationship
            builder.HasOne(x => x.Client).WithMany(x => x.Appointments)
                .HasForeignKey(x=>x.ClientId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Doctor).WithMany(x => x.Appointments)
                .HasForeignKey(x=>x.DoctorId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
