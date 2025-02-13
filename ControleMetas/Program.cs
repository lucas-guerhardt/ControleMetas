using ControleMetas.Forms;
using ControleMetas.Models;
using System.Diagnostics;
using DotNetEnv;

namespace ControleMetas
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // Carrega o arquivo .env da pasta raiz do projeto
            string envFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".env");
            Env.Load(envFilePath);

            var dbContext = new AppDbContext();
            dbContext.Database.EnsureCreated();

            ApplicationConfiguration.Initialize();
            Application.Run(new FrmControleMeta());
        }
    }
}