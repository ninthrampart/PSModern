using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSModern.Models
{
    public class PS
    {
        public int ID { get; set; }
        public Guid Bargain_Guid { get; set; }

        public virtual ICollection<Work> Works { get; set; }
    }
}
