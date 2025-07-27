using System;
using System.Linq;
using System.Windows.Forms;
using Datos.DataContext;
using Datos.Repositories;
using Negocio.Service;
using System.Collections.Generic;
using Modelo;
using Microsoft.EntityFrameworkCore;

namespace VistaOk
{
    public partial class Form1 : Form
    {
        private List<Producto> listaProductos = new List<Producto>();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            txtBuscar.TextChanged += TxtBuscar_TextChanged;
        }


        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("Cargando productos...");

                using (var context = new Session1Context())
                {
                    var repoPro = new ProductoRepository(context);
                    var servPro = new ProductoService(repoPro);
                    var productos = await servPro.ObtenerTodos();


                    listaProductos = productos
                        .Select(p => new Producto
                        {
                            IdProd = p.IdProd,
                            Activo = p.Activo,
                            NombreProd = p.NombreProd,
                            Precio = p.Precio,
                            Costo = p.Costo,
                            Descripcion = p.Descripcion,
                            FechaIntro = p.FechaIntro, // Descomentado
                            DetaOrdens = p.DetaOrdens, // Descomentado
                            IdCate = p.IdCate,
                            IdCategoriaNavigation = p.IdCategoriaNavigation

                        })
                        .ToList();

                    dataGridView1.Columns.Clear();
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = listaProductos;

                    //foreach (DataGridViewColumn col in dataGridView1.Columns)
                    //{
                    //    if (!new[] { "NombreProd", "Precio", "Costo", "Activo", "Descripcion", "" }.Contains(col.DataPropertyName))
                    //    {
                    //        col.Visible = true;
                    //    }
                    //}

                    //MessageBox.Show($"Productos cargados: {listaProductos.Count}");
                    // Agregar columnas para editar, eliminar o checkbox
                    AddActionColumn();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void AddActionColumn()
        {
            // Agregar columna de editar
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn
            {
                Name = "Editar",
                HeaderText = "Acciones",
                Text = "Editar",
                UseColumnTextForButtonValue = true,
                Width = 75
            };
            dataGridView1.Columns.Add(editColumn);

            // Agregar columna de eliminar
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
            {
                Name = "Eliminar",
                HeaderText = "Acciones",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true,
                Width = 75
            };
            dataGridView1.Columns.Add(deleteColumn);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Identificar la columna clickeada
            if (e.RowIndex >= 0) // Si se hizo clic en una fila
            {
                var selectedProduct = listaProductos[e.RowIndex];

                if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
                {
                    // Acción de editar
                    //EditProduct(selectedProduct);
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    // Acción de eliminar
                    DeleteProduct(selectedProduct);
                }
            }
        }

        //private async void EditProduct(Producto product)
        //{

        //    using (var context = new Session1Context())
        //    {
        //        var repoPro = new ProductoRepository(context);
        //        var servPro = new ProductoService(repoPro);


        //        FormEditProducto editForm = new FormEditProducto(product);

        //        if (editForm.ShowDialog() == DialogResult.OK)
        //        {
        //            // Obtener los datos del formulario de edición
        //            Producto updatedProduct = editForm.UpdatedProduct;

        //            // Actualizar el producto en la base de datos
        //            bool success = await servPro.Actualizar(updatedProduct);

        //            if (success)
        //            {
        //                // Actualizar la lista local
        //                var index = listaProductos.FindIndex(p => p.IdProd == product.IdProd);
        //                if (index >= 0)
        //                {
        //                    listaProductos[index] = updatedProduct;
        //                    dataGridView1.DataSource = null;
        //                    dataGridView1.DataSource = listaProductos;
        //                    MessageBox.Show("Producto actualizado correctamente.");
        //                }
        //            }
        //            else
        //            {
        //                //MessageBox.Show("No se pudo actualizar el producto.");
        //            }
        //        }
        //    }
        //}


        private async void DeleteProduct(Producto product)
        {
            // Confirmar si el usuario realmente quiere eliminar el producto
            var result = MessageBox.Show($"¿Estás seguro de eliminar el producto: {product.NombreProd}?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (var context = new Session1Context())
                {
                    var repoPro = new ProductoRepository(context);
                    var servPro = new ProductoService(repoPro);

                    // Eliminar el producto de la base de datos
                    bool success = await servPro.Eliminar(product.IdProd);

                    if (success)
                    {
                        // Eliminar el producto de la lista local
                        listaProductos.Remove(product);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = listaProductos;
                        MessageBox.Show($"Producto {product.NombreProd} eliminado.");
                    }
                    else
                    {
//                        MessageBox.Show("No se pudo eliminar el producto.");
                    }
                }
            }
        }




        private void FiltrarProductos(string textoBusqueda)
        {
            var productosFiltrados = listaProductos
                .Where(p => p.NombreProd.Contains(textoBusqueda, StringComparison.OrdinalIgnoreCase))
                .ToList();

            dataGridView1.DataSource = productosFiltrados;
        }



        private void BuscarE_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.Trim();

            if (!string.IsNullOrEmpty(textoBusqueda))
            {
                FiltrarProductos(textoBusqueda);
            }
            else
            {
                dataGridView1.DataSource = listaProductos;
            }
        }
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.Trim();

            if (!string.IsNullOrEmpty(textoBusqueda))
            {
                FiltrarProductos(textoBusqueda);
            }
            else
            {
                dataGridView1.DataSource = listaProductos;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}


