using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.DataContext;
using Modelo;

namespace Datos.Repositories
{
    public class CategoriumRepository : IAbstractCRUD<Categorium>
    {
        private readonly Session1Context _session1;

        public CategoriumRepository(Session1Context context) 
        {
            _session1 = context;
        }
        public async Task<bool> Actualizar(Categorium modelo)
        {
            _session1.Categoria.Update(modelo);
            await _session1.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Categorium modelo = _session1.Categoria.First(c=>c.IdCategoria == id);
            _session1.Categoria.Remove(modelo);
            await _session1.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Categorium modelo)
        {
            _session1.Categoria.Add(modelo);
            await _session1.SaveChangesAsync();
            return true;
        }

        public async Task<Categorium> Obtener(int id)
        {
            return await _session1.Categoria.FindAsync(id);
        }

        public async Task<IQueryable<Categorium>> ObtenerTodos()
        {
            IQueryable<Categorium> queryCategoriumSQL = _session1.Categoria;
            return queryCategoriumSQL;
        }
    }
}
