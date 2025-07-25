using System;
using System.Linq;
using System.Windows.Forms;
using Datos.DataContext;
using Datos.Repositories;
using Negocio.Service;

namespace VistaOk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load; // Asegura que el evento esté vinculado
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Cargando productos...");

                using (var context = new Session1Context())
                {
                    var repoPro = new ProductoRepository(context);
                    var servPro = new ProductoService(repoPro);

                    var productos = await servPro.ObtenerTodos();

                    var listaProd = productos
                        .Select(p => new
                        {
                            //p.IdProd,
                            p.Activo,
                            p.NombreProd,
                            p.Precio,
                            p.Costo
                            
                        })
                        .ToList();

                    dataGridView1.Columns.Clear();
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = listaProd;

                    MessageBox.Show($"Productos cargados: {listaProd.Count}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}


