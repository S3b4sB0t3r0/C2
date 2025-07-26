using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.DataContext;
using Modelo;

namespace Datos.Repositories
{
    public class EstadoORepository : IAbstractCRUD<EstadoO>
    {
        private readonly Session1Context _session1;
        public EstadoORepository(Session1Context context)
        {
            _session1 = context;
        }
        public async Task<bool> Actualizar(EstadoO modelo)
        {
            _session1.EstadoOs.Update(modelo);
            await _session1.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            EstadoO modelo = _session1.EstadoOs.First(c => c.IdEstadoO == id);
            _session1.EstadoOs.Remove(modelo);
            await _session1.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(EstadoO modelo)
        {
            _session1.EstadoOs.Add(modelo);
            await _session1.SaveChangesAsync();
            return true;
        }

        public async Task<EstadoO> Obtener(int id)
        {
            return await _session1.EstadoOs.FindAsync(id);
        }

        public async Task<IQueryable<EstadoO>> ObtenerTodos()
        {
            IQueryable<EstadoO> queryEstadoOSQL = _session1.EstadoOs;
            return queryEstadoOSQL;
        }
    }
}
