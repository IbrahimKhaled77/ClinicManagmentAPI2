using ClinicManagmentAPI_Repos.Models.EnitiesTypeConfiguraaions;
using ClinicManagmentAPI_Repos.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClinicManagementAPI.Context
{
    public class ClinicManagementDbContext : DbContext
    {
        public ClinicManagementDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new LaborityTestEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProcedureTitleEntityConfiguration());
            modelBuilder.ApplyConfiguration(new AppointmentEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new InvoiceEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MedicalProuducreEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MedicalReportEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MedicalReportAttachementEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MedicalReportLaborityTestEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MedicienEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MedicienRecordEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SickLeaveEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
        }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<LaborityTest> LaborityTests { get; set; }
        public virtual DbSet<MedicalProuducre> MedicalProuducres { get; set; }
        public virtual DbSet<MedicalReport> MedicalReports { get; set; }
        public virtual DbSet<MedicalReportAttachement> MedicalReportAttachements { get; set; }
        public virtual DbSet<MedicalReportLaborityTest> MedicalReportLaborities { get; set; }
        public virtual DbSet<Medicien> Mediciens { get; set; }
        public virtual DbSet<MedicienRecord> MedicienRecords { get; set; }
        public virtual DbSet<ProcedureTitle> ProcedureTitles { get; set; }
        public virtual DbSet<SickLeave> SickLeaves { get; set; }
        public virtual DbSet<User> Users { get; set; }   
    }
}
