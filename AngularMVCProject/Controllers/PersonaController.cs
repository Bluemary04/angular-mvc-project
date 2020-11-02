using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularMVCProject.Models;

namespace AngularMVCProject.Controllers
{
    public class PersonaController : ApiController
    {
        // GET: api/Persona
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Persona/5
        public Persona Get(int id)
        {
            GestorPersonas gPersona = new GestorPersonas();
            return gPersona.ObtenerPorId(id);
        }

        // POST: api/Persona
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Persona/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Persona/5
        public void Delete(int id)
        {
        }
    }
}
