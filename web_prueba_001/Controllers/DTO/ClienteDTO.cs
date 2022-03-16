using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_prueba_001.Controllers.DTO
{
    public class ClienteDTO
    {
        public int id { get; set; }
        public string nombres { get; set; }
        public string ap_paterno { get; set; }
        public string ap_materno { get; set; }
        public string nro_documento { get; set; }
        public string correo { get; set; }
        public string nro_contacto { get; set; }

    }
}