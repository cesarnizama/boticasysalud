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
    
    public partial class ALP_ORDEN_PREPARADO_INSUMO
    {
        public string num_orden_preparado { get; set; }
        public string cod_insumo { get; set; }
        public int cant_insumo { get; set; }
        public int cod_usu_regi { get; set; }
        public System.DateTime fec_usu_regi { get; set; }
        public Nullable<int> cod_usu_modi { get; set; }
        public Nullable<System.DateTime> fec_usu_modi { get; set; }
    
        public virtual ALP_INSUMO ALP_INSUMO { get; set; }
        public virtual ALP_ORDEN_PREPARADO ALP_ORDEN_PREPARADO { get; set; }
    }
}
