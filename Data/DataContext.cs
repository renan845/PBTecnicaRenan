using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PBTecnicaRenan.Models;

namespace PBTecnicaRenan.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        }
        public DbSet<User> Users {get;set;} 
        public DbSet<Role> Roles{get;set;}
        public DbSet<UserRol> UserRoles {get;set;}
        public DbSet<DataSet> DataSets{get; set;}
        public DbSet<Field> Fields{get; set;}
        public DbSet<Procedure> Procedures {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Procedure>(entity =>
            {
                // Relación con el usuario creador
                entity.HasOne(p => p.CreatedByUser)
                .WithMany(u => u.CreatedProcedures)
                .HasForeignKey(p => p.CreatedByUserID)
                .OnDelete(DeleteBehavior.Restrict); // O DeleteBehavior.NoAction
                entity.HasOne(p => p.LastModifiedUser)
                .WithMany(u => u.ModifiedProcedures)
                .HasForeignKey(p => p.LastModifiedUserID)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false); 
            });
        }
    }
}