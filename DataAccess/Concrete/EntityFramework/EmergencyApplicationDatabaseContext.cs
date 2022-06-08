using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EmergencyDatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=EmergencyDataBase;Trusted_Connection=True");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<SystemStaff> SystemStaves { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Voice> Voices { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
