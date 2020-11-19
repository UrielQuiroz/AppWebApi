using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWebApi.Models
{
    public class DoctorModel
    {
        public int IdDoctor { get; set; }
        public string NombreCompleto { get; set; }
        public string NombreClinica { get; set; }
        public string NombreEspecialidad { get; set; }
        public string Email { get; set; }
        public DateTime FechaContrato{ get; set; }
    }
}