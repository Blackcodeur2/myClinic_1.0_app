using MyClinic_1._0.src.cores.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClinic_1._0.src.data.entities
{
    public class Facture: BaseEntity
    {
        public int Id { get; set; }

        public string NumeroFacture { get; set; } = string.Empty;

        public int ConsultationId { get; set; }

        public int PatientId { get; set; }

        public DateTime DateFacture { get; set; }

        public DateTime? DateEcheance { get; set; }

        public decimal MontantHT { get; set; }

        public decimal MontantTVA { get; set; }

        public decimal MontantRemise { get; set; }

        public decimal MontantTTC { get; set; }

        public StatutFacture Statut { get; set; }

        public string? Notes { get; set; }

        public int CreatedByUserId { get; set; }

        // Navigation
        public Consultation Consultation { get; set; } = null!;

        public Patient Patient { get; set; } = null!;

        public Users CreatedByUser { get; set; } = null!;

        public ICollection<LigneFacture> LignesFacture { get; set; }
            = new List<LigneFacture>();

        public ICollection<Paiement> Paiements { get; set; }
            = new List<Paiement>();
    }
}
