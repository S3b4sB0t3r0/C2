using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Negocio.Service
{
    public class EstadoOService : IEstadoOService
    {
        public Task<bool> Actualizar(EstadoO modelo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insertar(EstadoO modelo)
        {
            throw new NotImplementedException();
        }

        public Task<EstadoO> Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<EstadoO>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
