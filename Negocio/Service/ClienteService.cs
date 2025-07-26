using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Repositories;
using Modelo;

namespace Negocio.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IAbstractCRUD<Cliente> _ClienteRepo;
        public ClienteService(IAbstractCRUD<Cliente> clienteRepo)
        {
            _ClienteRepo = clienteRepo;
        }
        public async Task<bool> Actualizar(Cliente modelo)
        {
            return await _ClienteRepo.Actualizar(modelo);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _ClienteRepo.Eliminar(id);
        }

        public async Task<bool> Insertar(Cliente modelo)
        {
            return await _ClienteRepo.Insertar(modelo);
        }

        public async Task<Cliente> Obtener(int id)
        {
            return await _ClienteRepo.Obtener(id);
        }

        public async Task<IQueryable<Cliente>> ObtenerTodos()
        {
            return await _ClienteRepo.ObtenerTodos();
        }
    }
}
