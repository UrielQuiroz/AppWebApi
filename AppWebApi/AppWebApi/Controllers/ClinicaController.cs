using AppWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace AppWebApi.Controllers
{
    public class ClinicaController : ApiController
    {
        MedicoEntities db;

        public ClinicaController()
        {
            db = new MedicoEntities();
        }

        [HttpGet]
        public IEnumerable<ClinicaModel> listarClinica()
        {
            IEnumerable<ClinicaModel> list = (from c in db.Clinica
                                              where c.BHABILITADO == 1
                                              select new ClinicaModel
                                              {
                                                  IdClinica = c.IIDCLINICA,
                                                  Nombre = c.NOMBRE
                                              }).ToList();

            return list;
        }
    }
}
