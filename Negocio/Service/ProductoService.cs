using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Repositories;
using Modelo;

namespace Negocio.Service
{
    public class ProductoService : IProductoService
    {
        private readonly IAbstractCRUD<Producto> _productoRepo;
        public ProductoService(IAbstractCRUD<Producto> productoRepo) 
        {
            _productoRepo = productoRepo;
        }
        public async Task<bool> Actualizar(Producto modelo)
        {
            return await _productoRepo.Actualizar(modelo);
        }

        public async Task<bool> Eliminar(int id)
        {
            return await _productoRepo.Eliminar(id);
        }

        public async Task<bool> Insertar(Producto modelo)
        {
            return await _productoRepo.Insertar(modelo);
        }

        public async Task<Producto> Obtener(int id)
        {
            return await _productoRepo.Obtener(id);
        }

        public async Task<Producto> ObtenerPorNombre(string NombreProd)
        {
            IQueryable<Producto> queryProductoSQL = await _productoRepo.ObtenerTodos();
            Producto producto = queryProductoSQL.Where(p => p.NombreProd == NombreProd).FirstOrDefault();
            return producto;
        }

        public async Task<IQueryable<Producto>> ObtenerTodos()
        {
            return await _productoRepo.ObtenerTodos();
        }
    }
}
