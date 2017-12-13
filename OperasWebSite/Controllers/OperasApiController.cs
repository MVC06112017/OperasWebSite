using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OperasWebSite.Models;

namespace OperasWebSite.Controllers
{
    public class OperasApiController : ApiController
    {
        private OperaDB context = new OperaDB();

        public IEnumerable<Opera> GetOperas()
        {
            return context.Operas.AsEnumerable();
        }

        public Opera GetOperas(int id)
        {
            Opera opera = context.Operas.Find(id);

            if (opera == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return opera;
        }
    }
}
