using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Repositories;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Negocio.Service
{
    public class CategoriumService : ICategoriumService
    {
        private readonly IAbstractCRUD<Categorium> _CategoriumRepo;
        public CategoriumService(IAbstractCRUD<Categorium> categoriumRepo)
        {
            _CategoriumRepo = categoriumRepo;
        }
        public async Task<bool> Actualizar(Categorium modelo)
        {
            return await _CategoriumRepo.Actualizar(modelo);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _CategoriumRepo.Eliminar(id);
        }

        public async Task<bool> Insertar(Categorium modelo)
        {
            return await _CategoriumRepo.Insertar(modelo);
        }

        public async Task<Categorium> Obtener(int id)
        {
            return await _CategoriumRepo.Obtener(id);
        }

        public async Task<IQueryable<Categorium>> ObtenerTodos()
        {
            return await _CategoriumRepo.ObtenerTodos();
        }
    }
}
