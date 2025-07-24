using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Negocio.Service
{
    public interface IDetaOrdenService
    {
        Task<bool> Insertar(DetaOrden modelo);
        Task<bool> Actualizar(DetaOrden modelo);
        Task<bool> Eliminar(int id);
        Task<DetaOrden> Obtener(int id);
        Task<IQueryable<DetaOrden>> ObtenerTodos();
    }
}
