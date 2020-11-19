using AppWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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



        [HttpPut]
        public int eliminarDoctor(int idDoctor)
        {
            int rpta = 0;

            try
            {
                Doctor oDoc = db.Doctor.Where(p => p.IIDDOCTOR == idDoctor).First();
                oDoc.BHABILITADO = 0;
                db.SaveChanges();
                rpta = 1;
            }
            catch (Exception ex)
            {
                rpta = 0;
            }

            return rpta;
        }


        [HttpGet]
        public DoctorModel recuperarDoctor(int idDoctor)
        {
            DoctorModel model = (from d in db.Doctor
                                 where d.IIDDOCTOR == idDoctor
                                 select new DoctorModel
                                 {
                                     IdDoctor = d.IIDDOCTOR,
                                     Nombre = d.NOMBRE,
                                     ApPaterno = d.APPATERNO,
                                     ApMaterno = d.APMATERNO,
                                     Email = d.EMAIL,
                                     FechaContrato = (DateTime)d.FECHACONTRATO,
                                     Archivo = d.ARCHIVO,
                                     nombreArchivo = d.NOMBRE,
                                     Sexo = (int) d.IIDSEXO,
                                     Sueldo = (decimal)d.SUELDO,
                                     celular = d.TELEFONOCELULAR,
                                     IdClinica = (int)d.IIDCLINICA,
                                     IdEspecialidad = (int)d.IIDESPECIALIDAD

                                 }).First();

            return model;
        }

    }
}
