using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Repositories;
using Modelo;

namespace Negocio.Service
{
    public class OrdenServicie : IOrdenService
    {
        private readonly IAbstractCRUD<Orden> _OrdenRepo;

        public OrdenServicie(IAbstractCRUD<Orden> ordenRepo)
        {
            _OrdenRepo = ordenRepo;
        }

        public async Task<bool> Actualizar(Orden modelo)
        {
            return await _OrdenRepo.Actualizar(modelo);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _OrdenRepo.Eliminar(id);
        }

        public async Task<bool> Insertar(Orden modelo)
        {
            return await _OrdenRepo.Insertar(modelo);
        }

        public async Task<Orden> Obtener(int id)
        {
            return await _OrdenRepo.Obtener(id);
        }

        public async Task<IQueryable<Orden>> ObtenerTodos()
        {
            return await _OrdenRepo.ObtenerTodos();
        }
    }
}
