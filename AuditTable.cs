using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AUTHORIZATION1.Data
{
    public class AuditTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AID { get; set; }
        public int UserID { get; set; }
        public string ActionTaken { get; set; }
        public DateTime Date { get; set; }
    }
}
