using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Repositories;
using Modelo;

namespace Negocio.Service
{
    public class EstadoOService : IEstadoOService
    {
        private readonly IAbstractCRUD<EstadoO> _EstadosRepo;

        public EstadoOService(IAbstractCRUD<EstadoO> estadosRepo)
        {
            _EstadosRepo = estadosRepo;
        }
        public async Task<bool> Actualizar(EstadoO modelo)
        {
            return await _EstadosRepo.Actualizar(modelo);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _EstadosRepo.Eliminar(id);
        }

        public async Task<bool> Insertar(EstadoO modelo)
        {
            return await _EstadosRepo.Insertar(modelo);
        }

        public async Task<EstadoO> Obtener(int id)
        {
            return await _EstadosRepo.Obtener(id);
        }

        public async Task<IQueryable<EstadoO>> ObtenerTodos()
        {
            return await _EstadosRepo.ObtenerTodos();
        }
    }
}
