using PSModern.Models;
using PSModern.Models.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PSModern.Controllers.api
{
    [RoutePrefix("api/ps")]
    public class PSController : ApiController
    {
        [Route("GetAllWorks")]
        public Collection<Work> GetAllWorks()
        {
            IWorkRepository rep = new EFWorkRepository();
            var a = rep.GetAll();

            return a;
        }

        [Route("GetAllBNs")]
        public Collection<BN> GetAllBNs()
        {
            IBNRepository rep = new EFBNRepository();
            var a = rep.GetAll();

            return a;
        }

    }
}
