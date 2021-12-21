using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace WebApplication8.Models
{
    public class UserContext: DbContext
    {
        public DbSet<User> Users { set; get; }
        public UserContext(DbContextOptions<UserContext> options) : base(options)// через json файл
        {
            Database.EnsureCreated();
        }
    }
}
