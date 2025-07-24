using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Negocio.Service
{
    public interface IOrdenService
    {
        Task<bool> Insertar(Orden modelo);
        Task<bool> Actualizar(Orden modelo);
        Task<bool> Eliminar(int id);
        Task<Orden> Obtener(int id);
        Task<IQueryable<Orden>> ObtenerTodos();
    }
}

