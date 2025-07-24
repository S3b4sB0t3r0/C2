using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Negocio.Service
{
    public interface ICategoriumService
    {
        Task<bool> Insertar(Categorium modelo);
        Task<bool> Actualizar(Categorium modelo);
        Task<bool> Eliminar(int id);
        Task<Categorium> Obtener(int id);
        Task<IQueryable<Categorium>> ObtenerTodos();
    }
}
