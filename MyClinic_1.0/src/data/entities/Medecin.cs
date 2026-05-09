using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClinic_1._0.src.data.entities
{
    public class Medecin : BaseEntity
    {
        public int Id { get; set; }

        public string Nom { get; set; } = string.Empty;

        public string Prenom { get; set; } = string.Empty;

        public string? Specialite { get; set; }

        public string? NumOrdre { get; set; }

        public string? Telephone { get; set; }

        // Navigation
        public ICollection<Consultation> Consultations { get; set; }
            = new List<Consultation>();
    }
}
