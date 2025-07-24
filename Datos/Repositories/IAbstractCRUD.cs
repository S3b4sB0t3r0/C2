using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositories
{
    public interface IAbstractCRUD<TEntityModel> where TEntityModel : class
    {
        Task<bool> Insertar(TEntityModel modelo);
        Task<bool> Actualizar(TEntityModel modelo);
        Task<bool> Eliminar(int id);
        Task<TEntityModel> Obtener(int id);
        Task<IQueryable<TEntityModel>> ObtenerTodos();

    }
}
