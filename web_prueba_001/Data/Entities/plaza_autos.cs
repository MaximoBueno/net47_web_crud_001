//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace web_prueba_001.Data.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class plaza_autos
    {
        public int id { get; set; }
        public int id_autos_cliente { get; set; }
        public int id_estado_plaza { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
        public Nullable<System.DateTime> fecha_actualiza { get; set; }
        public Nullable<int> estado { get; set; }
    
        public virtual autos_cliente autos_cliente { get; set; }
        public virtual estado_plaza estado_plaza { get; set; }
    }
}