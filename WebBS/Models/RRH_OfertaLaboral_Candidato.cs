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
    
    public partial class RRH_OfertaLaboral_Candidato
    {
        public int Cod_ofertalaboral_candidato { get; set; }
        public Nullable<int> Cod_ofertalaboral { get; set; }
        public Nullable<int> Cod_candidato { get; set; }
        public string Cod_usu_regi { get; set; }
        public Nullable<System.DateTime> Fec_usu_regi { get; set; }
        public string Cod_usu_modi { get; set; }
        public Nullable<System.DateTime> Fec_usu_modi { get; set; }
    
        public virtual RRH_OfertaLaboral RRH_OfertaLaboral { get; set; }
        public virtual RRH_Candidato RRH_Candidato { get; set; }
    }
}
