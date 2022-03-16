using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_prueba_001.Models
{
    //referenciar bien la clase cliente
    public class Cliente
    {
        public int id { get; set; }
        public string nombres { get; set; }
        public string ap_paterno { get; set; }
        public string ap_materno { get; set; }
        public string nro_documento { get; set; }
        public string correo { get; set; }
        public string nro_contacto { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
        public Nullable<System.DateTime> fecha_actualiza { get; set; }
        public Nullable<int> estado { get; set; }
    }
}