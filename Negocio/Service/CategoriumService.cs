using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Negocio.Service
{
    public class CategoriumService : ICategoriumService
    {
        public Task<bool> Actualizar(Categorium modelo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insertar(Categorium modelo)
        {
            throw new NotImplementedException();
        }

        public Task<Categorium> Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Categorium> ObtenerPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Categorium>> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
