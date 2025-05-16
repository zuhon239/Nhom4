using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MidtermTest.Model;

namespace MidtermTest
{
    public class Context : DbContext
    {
        public DbSet<transactions> Transaction { get; set; }
        public DbSet<bank_account> Bank_account { get; set; }
        public string DbPath { get; }      
        public Context()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = @"C:\Users\Administrator\source\repos\MidtermTest\MidtermTest\data.db";
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<transactions>(entity =>
            {
                entity.HasKey(e => e.trans_id);
                entity.HasOne(t => t.bank_account)
                  .WithMany(ba => ba.Transactions)
                  .HasForeignKey(t => t.account_id);
            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlite($"Data Source={DbPath}");
            }           
        }
            
    }  
}
