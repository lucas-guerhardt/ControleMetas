using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEnv;
using Microsoft.EntityFrameworkCore;

namespace ControleMetas.Models
{
    public class AppDbContext : DbContext
    /*Classe para criar o banco de dados*/
    {
        public DbSet<MetaModel> Metas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dotenvPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".env");
            DotNetEnv.Env.Load(dotenvPath);

            string user = Environment.GetEnvironmentVariable("MYSQL_USER") ?? "root";
            string port = Environment.GetEnvironmentVariable("MYSQL_PORT") ?? "3306";
            string password = Environment.GetEnvironmentVariable("MYSQL_PASSWORD") ?? "";

            string connectionString = $"server=localhost;port={port};user={user};password={password};database=controle_metas";

            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8,0,40)));
        }

        public void EnsureDataBaseCreated()
        {
            Database.EnsureCreated();
        }
    }
}
