using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Negocio.Service
{
    public class OrdenServicie : IOrdenService
    {
        public Task<bool> Actualizar(Orden modelo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insertar(Orden modelo)
        {
            throw new NotImplementedException();
        }

        public Task<Orden> Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Orden>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
