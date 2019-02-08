using ExamenAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExamenAPI.Controllers
{
    public class RecetasController : ApiController
    {
        // GET: api/Recetas
        public IEnumerable<Receta> Get()
        {
            var repo = new RecetaRepository();
            List<Receta> listaRecetas = repo.RecuperarRecetas();

            return listaRecetas;
        }

            // GET: api/Recetas/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Recetas
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Recetas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Recetas/5
        public void Delete(int id)
        {
        }
    }
}
