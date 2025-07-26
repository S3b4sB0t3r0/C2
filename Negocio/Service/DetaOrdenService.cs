using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Repositories;
using Modelo;

namespace Negocio.Service
{
    public class DetaOrdenService : IDetaOrdenService
    {
        private readonly IAbstractCRUD<DetaOrden> _DetaOrdenRepo;
        public DetaOrdenService(IAbstractCRUD<DetaOrden> detaordenRepo)
        {
            _DetaOrdenRepo = detaordenRepo;
        }
        public async Task<bool> Actualizar(DetaOrden modelo)
        {
            return await _DetaOrdenRepo.Actualizar(modelo);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _DetaOrdenRepo.Eliminar(id);
        }

        public async Task<bool> Insertar(DetaOrden modelo)
        {
            return await _DetaOrdenRepo.Insertar(modelo);
        }

        public async Task<DetaOrden> Obtener(int id)
        {
            return await _DetaOrdenRepo.Obtener(id);
        }

        public async Task<IQueryable<DetaOrden>> ObtenerTodos()
        {
            return await _DetaOrdenRepo.ObtenerTodos();
        }
    }
}
