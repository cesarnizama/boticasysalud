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
    
    public partial class IMP_SOLICITUD
    {
        public IMP_SOLICITUD()
        {
            this.IMP_SOLICITUD_GESTION_PERMISO = new HashSet<IMP_SOLICITUD_GESTION_PERMISO>();
            this.IMP_SOLICITUD_IMPORTACION = new HashSet<IMP_SOLICITUD_IMPORTACION>();
        }
    
        public int Cod_solicitud { get; set; }
        public Nullable<System.DateTime> Fec_emision { get; set; }
        public byte[] Descripcion { get; set; }
        public string Observaciones { get; set; }
        public string Estado { get; set; }
        public int Cod_usu_regi { get; set; }
        public System.DateTime Fec_usu_regi { get; set; }
        public Nullable<int> Cod_usu_modi { get; set; }
        public Nullable<System.DateTime> Fec_usu_modi { get; set; }
    
        public virtual ICollection<IMP_SOLICITUD_GESTION_PERMISO> IMP_SOLICITUD_GESTION_PERMISO { get; set; }
        public virtual ICollection<IMP_SOLICITUD_IMPORTACION> IMP_SOLICITUD_IMPORTACION { get; set; }
    }
}
