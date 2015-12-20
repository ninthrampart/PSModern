using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSModern.Models.Repository
{
    interface IWorkRepository
    {

        Collection<Work> GetAll();
        Collection<Work> GetByPS(int psid);
        Work GetById(int id);
    }
}
