using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using web_prueba_001.Controllers.DTO;
using web_prueba_001.Data.Entities;
using web_prueba_001.Data.Repositories;

namespace web_prueba_001.Controllers.Api
{

    public class ClienteController : ApiController
    {
        // GET: api/Cliente

        private ClienteRepository clienteRepository;

        public ClienteController()
        {
            this.clienteRepository = new ClienteRepository();
        }

        [System.Web.Http.HttpGet]
        public JsonResult<List<clientes>> clientes()
        {
            return Json(this.clienteRepository.getClientes());
        }

        [System.Web.Http.HttpPost]
        public void eliminar(string id)
        {

            if(id.Length > 0){
                try{

                    int mi_id = Convert.ToInt32(id.Replace("eliminar", ""));
                    this.clienteRepository.eliminar(mi_id);
                }
                catch(Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
               
            }

            
        }

        [System.Web.Http.HttpPost]
        public void guardar(ClienteDTO c)
        {

            try
            {
                clientes clie = new clientes();

                clie.id = c.id;
                clie.nombres = c.nombres;
                clie.ap_paterno = c.ap_paterno;
                clie.ap_materno = c.ap_materno;
                clie.nro_documento = c.nro_documento;

                clie.correo = c.correo;
                clie.nro_contacto = c.nro_contacto;

                this.clienteRepository.guardar(clie);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }


        }

    }
}
