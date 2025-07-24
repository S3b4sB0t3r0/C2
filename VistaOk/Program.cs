using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Datos.DataContext;
using Modelo;
using Datos.Repositories;
using Negocio.Service;


namespace VistaOk
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            // Configurar archivo de configuración
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Agregar la cadena de conexión
            string connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<Session1Context>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            // Agregar servicios (inyección de dependencias)
            services.AddScoped<IAbstractCRUD<Producto>, ProductoRepository>();
            services.AddScoped<IProduc, ProductoService>();

            // Crear el ServiceProvider
            ServiceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();

            // Resolves Form1 con sus dependencias (si las tiene)
            var form1 = ServiceProvider.GetRequiredService<Form1>();
            Application.Run(form1);
        }
    }
}
