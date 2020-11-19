//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppWebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Medicamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medicamento()
        {
            this.ConsultaMedicamento = new HashSet<ConsultaMedicamento>();
        }
    
        public int IIDMEDICAMENTO { get; set; }
        public string NOMBRE { get; set; }
        public string CONCENTRACION { get; set; }
        public Nullable<int> IIDFORMAFARMACEUTICA { get; set; }
        public Nullable<decimal> PRECIO { get; set; }
        public Nullable<int> STOCK { get; set; }
        public string PRESENTACION { get; set; }
        public Nullable<int> BHABILITADO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConsultaMedicamento> ConsultaMedicamento { get; set; }
        public virtual FormaFarmaceutica FormaFarmaceutica { get; set; }
    }
}
