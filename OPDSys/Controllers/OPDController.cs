using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OPDManagementSystem.Models; 

namespace OPDSys.Controllers
{
    public class OPDController : ApiController
    {
        public IHttpActionResult GetPatient()
        {
            var pat = new InternationalPatient(12, "Morgan", "Smolder");
            return Ok(pat);
        }

        public IHttpActionResult GetPatient(int id)
        {
            var pat = new InternationalPatient(12, "Morgan", "Smolder");
            return Ok(pat);
        }
    }

    
}
