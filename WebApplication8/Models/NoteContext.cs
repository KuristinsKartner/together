using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
namespace WebApplication8.Models
{
    public class NoteContext : DbContext
    {
        

        

        public DbSet<Note> Users { set; get; }
        public NoteContext(DbContextOptions<NoteContext> options) : base(options)// через json файл
        {
            Database.EnsureCreated(); // создаст в sql, если не найдет
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // подключение к БД
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=users; Trusted_Connection = true;"); 
        }
        // помотреть, что здесь твориться
    /*    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            OnModelCreatingPartial(modelBuilder);
        }
    */
    //    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
