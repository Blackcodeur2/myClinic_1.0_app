using Microsoft.EntityFrameworkCore;
using MyClinic_1._0.src.data.entities;

namespace MyClinic_1._0.src.data.database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Users> Users => Set<Users>();
        public DbSet<Patient> Patients => Set<Patient>();
        public DbSet<Medecin> Medecins => Set<Medecin>();
        public DbSet<ActeMedical> ActesMedicaux => Set<ActeMedical>();
        public DbSet<Consultation> Consultations => Set<Consultation>();
        public DbSet<Facture> Factures => Set<Facture>();
        public DbSet<LigneFacture> LignesFacture => Set<LigneFacture>();
        public DbSet<Paiement> Paiements => Set<Paiement>();
        public DbSet<AuditLog> AuditLogs => Set<AuditLog>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Consultation>()
                .HasOne(c => c.Facture)
                .WithOne(f => f.Consultation)
                .HasForeignKey<Facture>(f => f.ConsultationId);

            modelBuilder.Entity<Facture>()
                .HasIndex(f => f.NumeroFacture)
                .IsUnique();

            modelBuilder.Entity<Users>()
                .HasIndex(u => u.Login)
                .IsUnique();
        }
    }
}