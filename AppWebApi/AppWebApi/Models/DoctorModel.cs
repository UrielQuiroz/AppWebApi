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

        //Propiedades Adicionales
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; } 
        public string Archivo { get; set; } 
        public string nombreArchivo { get; set; } 
        public int Sexo { get; set; } 
        public string celular { get; set; } 
        public decimal Sueldo { get; set; }
        public int IdClinica { get; set; }
        public int IdEspecialidad { get; set; }
    }
}