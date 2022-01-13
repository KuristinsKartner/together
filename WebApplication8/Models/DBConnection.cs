using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//using Microsoft.EntityFrameworkCore;
namespace WebApplication8.Models
{
    public class DBConnection //: DbContext
    {   // подключение к бд
        MySqlConnection connection = new MySqlConnection("server=localhost; port=3306; username=root; password=root; database=db");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
        //public DbSet<Note> Users { set; get; }
        //public DBConnection(DbContextOptions<DBConnection> options) : base(options)// через json файл
        //{
        //    Database.EnsureCreated(); // создаст в sql, если не найдет
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // подключение к БД
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=users; Trusted_Connection = true;"); 
        //}
        //// помотреть, что здесь твориться
        //    protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    {
        //        modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");
        //    }
        //
        ////    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
