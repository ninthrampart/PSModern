using PSModern.Models.DAL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSModern.Models.Repository
{
    public class EFBNRepository : IBNRepository
    {
        private PSContext _db;

        public EFBNRepository()
        {
            _db = new PSContext();
        }
        public Collection<BN> GetAll()
        {
            ObservableCollection<BN> bns = new ObservableCollection<BN>(_db.BNs.ToList());
            return bns;            
        }

        public BN GetById(int id)
        {
            var bn = _db.BNs.Where(x => x.ID == id).ToList();

            if(bn.Count() > 0)
            {
                return bn.First();
            }
            else
            {
                return null;
            }
        }
    }
}
