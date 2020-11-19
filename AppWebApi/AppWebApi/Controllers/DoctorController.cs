using AppWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppWebApi.Controllers
{
    public class DoctorController : ApiController
    {
        MedicoEntities db;

        public DoctorController()
        {
            db = new MedicoEntities();
        }

        // GET: api/Doctor
        [System.Web.Http.HttpGet]
        public IEnumerable<DoctorModel> ListarDoctor()
        {
            IEnumerable<DoctorModel> listDoctor = (from d in db.Doctor
                                                   join c in db.Clinica on d.IIDCLINICA equals c.IIDCLINICA
                                                   join e in db.Especialidad on d.IIDESPECIALIDAD equals e.IIDESPECIALIDAD
                                                   where d.BHABILITADO == 1
                                                   select new DoctorModel
                                                   {
                                                       IdDoctor = d.IIDDOCTOR,
                                                       NombreCompleto = d.NOMBRE + " " + d.APMATERNO,
                                                       NombreClinica = c.NOMBRE,
                                                       NombreEspecialidad = e.NOMBRE,
                                                       Email = d.EMAIL,
                                                       FechaContrato = (DateTime)d.FECHACONTRATO
                                                   }).ToList();

            return listDoctor;
        }
    }
}
