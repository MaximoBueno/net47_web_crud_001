using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web_prueba_001.Data.Entities;
using web_prueba_001.Data.Repositories.Interfaces;
using web_prueba_001.Models;

namespace web_prueba_001.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {


        private bd_estacionamientosEntities _bd_EstacionamientosEntities;
        public ClienteRepository()
        {
            this._bd_EstacionamientosEntities = new bd_estacionamientosEntities();
        }

        public void eliminar(int id)
        {
            
            clientes  clie = (from cli in _bd_EstacionamientosEntities.clientes
                             where cli.id == id
                             select cli).FirstOrDefault();

            if(clie != null){
                _bd_EstacionamientosEntities.clientes.Remove(clie);
                _bd_EstacionamientosEntities.SaveChanges();
            }
        }

        public List<clientes> getClientes()
        {
            try{
                return (from cli in _bd_EstacionamientosEntities.clientes
                        select cli).ToList();
            }catch(Exception ex){
                return null;
            }
           
        }

        public void guardar(clientes c)
        {
            
            if(c.id.ToString() == "" || c.id == 0){
                _bd_EstacionamientosEntities.clientes.Add(c);
                _bd_EstacionamientosEntities.SaveChanges();
            }  else{

                clientes clie = (from cli in _bd_EstacionamientosEntities.clientes
                                 where cli.id == c.id
                                 select cli).FirstOrDefault();

                clie.nombres = c.nombres;
                clie.ap_paterno = c.ap_paterno;
                clie.ap_materno = c.ap_materno;
                clie.nro_documento = c.nro_documento;

                clie.correo = c.correo;
                clie.nro_contacto = c.nro_contacto;

                _bd_EstacionamientosEntities.SaveChanges();

            }
           
        }



        public Cliente obtener(int id)
        {
            clientes micliente = (from cli in _bd_EstacionamientosEntities.clientes
                                  where cli.id == id
                                  select cli).FirstOrDefault();
            Cliente cliente = new Cliente();

            //instalar, con nuget, mapper para hacer automatico
            if(micliente != null)
            {
                cliente.id = micliente.id;
                cliente.nombres = micliente.nombres;
                cliente.ap_paterno = micliente.ap_paterno;
                cliente.ap_materno = micliente.ap_materno;
                cliente.nro_documento = micliente.nro_documento;
                cliente.correo = micliente.correo;
                cliente.nro_contacto = micliente.nro_contacto;
                cliente.fecha_creacion = micliente.fecha_creacion;
                cliente.fecha_actualiza = micliente.fecha_actualiza;
                cliente.estado = micliente.estado;
            }

            return cliente;
        }

    }
}