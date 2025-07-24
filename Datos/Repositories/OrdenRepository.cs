using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.DataContext;
using Modelo;

namespace Datos.Repositories
{
    public class OrdenRepository : IAbstractCRUD<Orden>
    {
        private readonly Session1Context _session1;
        public OrdenRepository(Session1Context context)
        {
            _session1 = context;
        }

        public async Task<bool> Actualizar(Orden modelo)
        {
            _session1.Ordens.Update(modelo);
            await _session1.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Orden modelo = _session1.Ordens.First(c => c.IdOrden == id);
            _session1.Ordens.Remove(modelo);
            await _session1.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Orden modelo)
        {
            _session1.Ordens.Add(modelo);
            await _session1.SaveChangesAsync();
            return true;
        }

        public async Task<Orden> Obtener(int id)
        {
            return await _session1.Ordens.FindAsync(id);
        }

        public async Task<IQueryable<Orden>> ObtenerTodos()
        {
            IQueryable<Orden> queryCategoriumSQL = _session1.Ordens;
            return queryCategoriumSQL;
        }
    }
}
