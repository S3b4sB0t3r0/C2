using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.DataContext;
using Modelo;

namespace Datos.Repositories
{
    public class ClienteRepository : IAbstractCRUD<Cliente>
    {
        private readonly Session1Context _session1;

        public ClienteRepository(Session1Context context) 
        {
            _session1 = context;
        }
        public async Task<bool> Actualizar(Cliente modelo)
        {
            _session1.Clientes.Update(modelo);
            await _session1.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Eliminar(int id)
        {
            Cliente modelo = _session1.Clientes.First(c => c.IdCliente == id);
            _session1.Clientes.Remove(modelo);
            await _session1.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Insertar(Cliente modelo)
        {
            _session1.Clientes.Add(modelo);
            await _session1.SaveChangesAsync();
            return true;
        }

        public async Task<Cliente> Obtener(int id)
        {
            return await _session1.Clientes.FindAsync(id);
        }

        public async Task<IQueryable<Cliente>> ObtenerTodos()
        {
            IQueryable<Cliente> queryCategoriumSQL = _session1.Clientes;
            return queryCategoriumSQL;
        }
    }
}
