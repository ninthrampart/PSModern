using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSModern.Models.Repository
{
    interface IBNRepository
    {
        Collection<BN> GetAll();
        BN GetById(int id);
    }
}
