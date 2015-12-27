using PSModern.Models.DAL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSModern.Models.Repository
{
    public class EFResTypeRepository : IResTypeRepository
    {

        private PSContext _db;

        public EFResTypeRepository()
        {
            _db = new PSContext();
        }

        public Collection<ResType> GetAll()
        {
            ObservableCollection<ResType> resTypes = new ObservableCollection<ResType>(_db.ResTypes.ToList());
            return resTypes;
            //throw new NotImplementedException();
        }

        public ResType GetById(int id)
        {
            var resType = _db.ResTypes.Where(x => x.ID == id).ToList();
            return resType.FirstOrDefault();
            //throw new NotImplementedException();
        }
    }
}
