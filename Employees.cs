using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AUTHORIZATION1.Data
{
    public class Employees
    {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public int EID{ get; set; }
       
        public string FN{ get; set; }
        public string LN{ get; set; }
        public int Approved { get; set; }
        public DateTime Date{ get; set; }
        

       
    }
}
