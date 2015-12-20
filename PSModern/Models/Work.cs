using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSModern.Models
{
    public class Work
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Executioner { get; set; }
        public decimal InternalPrice { get; set; }
        public decimal ExternalPrice { get; set; }
        public decimal Tax { get; set; }
        public decimal PMP { get; set; }


        public int WorkTypeID { get; set; }
        public int ResTypeID { get; set; }
        public int BNID { get; set; }

        public virtual WorkType WType { get; set; }
        public virtual ResType RType { get; set; }
        public virtual BN  BNUnit { get; set; }

    }
}
