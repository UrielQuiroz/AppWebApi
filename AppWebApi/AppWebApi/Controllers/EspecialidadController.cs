using AppWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppWebApi.Controllers
{
    public class EspecialidadController : ApiController
    {
        MedicoEntities db;

        public EspecialidadController()
        {
            db = new MedicoEntities();
        }

        [HttpGet]
        public IEnumerable<EspecialidadModel> listEspecialidad()
        {
            IEnumerable<EspecialidadModel> list = (from e in db.Especialidad
                                                   where e.BHABILITADO == 1
                                                   select new EspecialidadModel
                                                   {
                                                       IdEspecialidad = e.IIDESPECIALIDAD,
                                                       Nombre = e.NOMBRE
                                                   }).ToList();

            return list;
        }
    }
}
