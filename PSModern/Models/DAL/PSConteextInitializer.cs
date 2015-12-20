using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSModern.Models.DAL
{
    public class PSConteextInitializer : CreateDatabaseIfNotExists<PSContext>
    {
        protected override void Seed(PSContext context)
        {
            base.Seed(context);
        }
    }
}
