//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RYA_TRANSA_ALMA
    {
        public RYA_TRANSA_ALMA()
        {
            this.RYA_MOVALM_CAB = new HashSet<RYA_MOVALM_CAB>();
        }
    
        public string Cod_Tran { get; set; }
        public string Descripcion { get; set; }
        public string tipo { get; set; }
        public string Cod_usu_regi { get; set; }
        public Nullable<System.DateTime> Fec_usu_regi { get; set; }
        public string Cod_usu_modi { get; set; }
        public Nullable<System.DateTime> Fec_usu_modi { get; set; }
    
        public virtual ICollection<RYA_MOVALM_CAB> RYA_MOVALM_CAB { get; set; }
    }
}
