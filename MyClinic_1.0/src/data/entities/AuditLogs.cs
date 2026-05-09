using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClinic_1._0.src.data.entities
{
    public class AuditLog
    {
        public long Id { get; set; }

        public int UserId { get; set; }

        public string Action { get; set; } = string.Empty;

        public string TableConcernee { get; set; } = string.Empty;

        public int EnregistrementId { get; set; }

        public string? AncienneValeur { get; set; }

        public string? NouvelleValeur { get; set; }

        public string? IpAdresse { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation
        public Users Utilisateur { get; set; } = null!;
    }
}
