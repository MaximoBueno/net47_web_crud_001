using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_prueba_001.Data.Entities;
using web_prueba_001.Models;

namespace web_prueba_001.Data.Repositories.Interfaces
{
    interface IClienteRepository
    {
        void eliminar(int id);
        void guardar(clientes c);
        Cliente obtener(int id); //el unico que extiende de Models
        List<clientes> getClientes(); 
    }
}
