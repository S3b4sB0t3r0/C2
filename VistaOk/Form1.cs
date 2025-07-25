using System.Data;
using Datos.DataContext;
using Datos.Repositories;
using Modelo;
using Negocio.Service;

namespace VistaOk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            


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

                    //dataGridView1.DataSource = productos
                    //    .Select(p => new
                    //    {
                    //       // p.IdProd,
                    //        p.NombreProd,
                    //        p.Precio,
                    //        p.Costo,
                    //       // p.Descripcion,
                    //        p.Activo
                    //       // p.FechaIntro
                    //    })
                    //    .ToList();


                    var listaProd = productos
                        .Select(p => new
                        {
                            //p.IdProd,
                            p.NombreProd,
                            p.Precio,
                            p.Costo,
                            //p.Descripcion,
                            p.Activo
                            //p.FechaIntro
                        })
                        .ToList();


                    var bindingSource1 = new BindingSource();
                    bindingSource1.DataSource = listaProd;

                    dataGridView1.DataSource = bindingSource1;

                    MessageBox.Show($"Productos cargados: {listaProd.Count}");

                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            };

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
