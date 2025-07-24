using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.DataContext;
using Modelo;

namespace Datos.Repositories
{

    public class DetaOrdenRepository : IAbstractCRUD<DetaOrden>
    {
        private readonly Session1Context _session1;

        public DetaOrdenRepository(Session1Context context)
        {
            _session1 = context;
        }
        public async Task<bool> Actualizar(DetaOrden modelo)
        {
            _session1.DetaOrdens.Update(modelo);
            await _session1.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            DetaOrden modelo = _session1.DetaOrdens.First(c => c.IdDeta == id);
            _session1.DetaOrdens.Remove(modelo);
            await _session1.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(DetaOrden modelo)
        {
            _session1.DetaOrdens.Add(modelo);
            await _session1.SaveChangesAsync();
            return true;
        }

        public async Task<DetaOrden> Obtener(int id)
        {
            return await _session1.DetaOrdens.FindAsync(id);
        }

        public async Task<IQueryable<DetaOrden>> ObtenerTodos()
        {
            IQueryable<DetaOrden> queryCategoriumSQL = _session1.DetaOrdens;
            return queryCategoriumSQL;
        }
    }
}
