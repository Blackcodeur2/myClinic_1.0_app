using MyClinic_1._0.src.cores.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClinic_1._0.src.data.entities
{
    public class Consultation: BaseEntity
    {
        public int Id { get; set; }

        public int PatientId { get; set; }

        public int MedecinId { get; set; }

        public DateTime DateConsultation { get; set; }

        public string? Motif { get; set; }

        public string? Observations { get; set; }

        public StatutConsultation Statut { get; set; }

        public int CreatedByUserId { get; set; }

        // Navigation
        public Patient Patient { get; set; } = null!;

        public Medecin Medecin { get; set; } = null!;

        public Users CreatedByUser { get; set; } = null!;

        public Facture? Facture { get; set; }
    }
}
