using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Negocio.Service
{
    public interface IEstadoOService
    {
        Task<bool> Insertar(EstadoO modelo);
        Task<bool> Actualizar(EstadoO modelo);
        Task<bool> Eliminar(int id);
        Task<EstadoO> Obtener(int id);
        Task<IQueryable<EstadoO>> ObtenerTodos();
    }
}
