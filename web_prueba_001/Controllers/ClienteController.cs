using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using web_prueba_001.Data.Repositories;
using web_prueba_001.Data.Repositories.Interfaces;
using web_prueba_001.Models;

namespace web_prueba_001.Controllers
{
    public class ClienteController : Controller
    {
        private IClienteRepository clienteRepository;
        public ClienteController()
        {
            clienteRepository = new ClienteRepository();
        }

        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Nuevo()
        {
            return View();
        }

        //Cliente/Editar/5
        public ActionResult Editar(string id)
        {

            Cliente cli = new Cliente();

            if (id != string.Empty)
            {
                cli = clienteRepository.obtener(Convert.ToInt32(id));
            }

            return View(cli);
        }


    }
}
