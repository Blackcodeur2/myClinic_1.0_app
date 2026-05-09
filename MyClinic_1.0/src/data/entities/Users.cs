using MyClinic_1._0.src.cores.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClinic_1._0.src.data.entities
{
    public class Users:BaseEntity
    {
        public int Id { get; set; }

        public string Login { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public RoleUtilisateur Role { get; set; }

        public DateTime? DernierAcces { get; set; }

        // Navigation
        public ICollection<Facture> FacturesCreees { get; set; }
            = new List<Facture>();

        public ICollection<Consultation> ConsultationsCreees { get; set; }
            = new List<Consultation>();

        public ICollection<Paiement> Paiements { get; set; }
            = new List<Paiement>();
    }
}
