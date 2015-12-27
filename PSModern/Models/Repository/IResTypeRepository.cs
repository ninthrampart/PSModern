using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSModern.Models.Repository
{
    interface IResTypeRepository
    {
        Collection<ResType> GetAll();
        ResType GetById(int id);
    }
}
