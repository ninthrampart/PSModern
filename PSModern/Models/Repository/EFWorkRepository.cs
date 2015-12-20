using PSModern.Models.DAL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSModern.Models.Repository
{
    public class EFWorkRepository : IWorkRepository
    {
        private PSContext _db;

        public EFWorkRepository()
        {
            _db = new PSContext();
        }

        public Collection<Work> GetAll()
        {
            ObservableCollection<Work> works = new ObservableCollection<Work>(_db.Works.ToList());
            return works;
            //throw new NotImplementedException();
        }

        public Work GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Collection<Work> GetByPS(int psid)
        {
            throw new NotImplementedException();
        }
    }
}
