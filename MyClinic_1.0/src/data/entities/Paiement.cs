using MyClinic_1._0.src.cores.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClinic_1._0.src.data.entities
{
    public class Paiement
    {
        public int Id { get; set; }

        public int FactureId { get; set; }

        public DateTime DatePaiement { get; set; }

        public decimal Montant { get; set; }

        public ModePaiement ModePaiement { get; set; }

        public string? Reference { get; set; }

        public string NumRecu { get; set; } = string.Empty;

        public int CaissierId { get; set; }

        public string? Notes { get; set; }

        // Navigation
        public Facture Facture { get; set; } = null!;

        public Users Caissier { get; set; } = null!;
    }
}
