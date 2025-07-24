using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Negocio.Service
{
    public class DetaOrdenService : IDetaOrdenService
    {
        public Task<bool> Actualizar(DetaOrden modelo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insertar(DetaOrden modelo)
        {
            throw new NotImplementedException();
        }

        public Task<DetaOrden> Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<DetaOrden>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
