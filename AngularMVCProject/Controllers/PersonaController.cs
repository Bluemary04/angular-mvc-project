using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;
using AngularMVCProject.Models;

namespace AngularMVCProject.Controllers
{

    [Authorize]
    [RoutePrefix("api/persona")]
    public class PersonaController : ApiController
    {

        // GET: api/Persona
        public IEnumerable<Persona> Get()
        {
            GestorPersonas gPersona = new GestorPersonas();
            return gPersona.ObtenerPersonas();
        }


        public Persona Get(int id)
        {
            GestorPersonas gPersona = new GestorPersonas();
            return gPersona.ObtenerPorId(id);
        }

        // POST: api/Persona
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Persona/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Persona/5
        public void Delete(int id)
        {
        }
    }
}
