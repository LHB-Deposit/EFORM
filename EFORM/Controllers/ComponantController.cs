using EFORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EFORM.Controllers
{
    public class ComponantController : ApiController
    {
        // GET: api/Componant
        public IEnumerable<PersonalViewModel> Get()
        {
            return new List<PersonalViewModel>
            {
                new PersonalViewModel
                {
                    IdNo = "316*********1",
                    NameTh = "พรชัย",
                    SurenameTh = "สมภาวะ",
                    NameEn = "Pornchai",
                    SurenameEn = "Sompava",
                    DateOfBirth = new DateTime(1981,6,12).ToString("dd/MM/yyyy"),
                    LaserNo = "ME********76"
                }
            };
        }

        // GET: api/Componant/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Componant
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Componant/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Componant/5
        public void Delete(int id)
        {
        }
    }
}
