using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.DataContext;
using Modelo;

namespace Datos.Repositories
{
    public class ProductoRepository : IAbstractCRUD<Producto>
    {
        private readonly Session1Context _session1;
        public ProductoRepository(Session1Context context)
        {
            _session1 = context;
        }
        public async Task<bool> Actualizar(Producto modelo)
        {
            _session1.Productos.Update(modelo);
            await _session1.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Producto modelo = _session1.Productos.First(c => c.IdProd == id);
            _session1.Productos.Remove(modelo);
            await _session1.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Producto modelo)
        {
            _session1.Productos.Add(modelo);
            await _session1.SaveChangesAsync();
            return true;
        }

        public async Task<Producto> Obtener(int id)
        {
            return await _session1.Productos.FindAsync(id);
        }

        public async Task<IQueryable<Producto>> ObtenerTodos()
        {
            IQueryable<Producto> queryCategoriumSQL = _session1.Productos;
            return queryCategoriumSQL;
        }
    }
}
