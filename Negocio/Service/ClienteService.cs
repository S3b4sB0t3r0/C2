using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Negocio.Service
{
    public class ClienteService : IClienteService
    {
        public Task<bool> Actualizar(Cliente modelo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insertar(Cliente modelo)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Cliente>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
