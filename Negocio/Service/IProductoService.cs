﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;


namespace Negocio.Service
{
    public interface IProductoService
    {
        Task<bool> Insertar(Producto modelo);
        Task<bool> Actualizar(Producto modelo);
        Task<bool> Eliminar(int id);
        Task<Producto> Obtener(int id);
        Task<IQueryable<Producto>> ObtenerTodos();
        Task<Producto> ObtenerPorNombre(string NombreProd);
    }
}
