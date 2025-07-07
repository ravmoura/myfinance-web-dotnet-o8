using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using myfinance_web_dotnet_o8.Domain;


namespace myfinance_web_dotnet_o8.Infraestrutucture
{
    public class  MyFinanceDbContext : DbContext 
    {
        public DbSet<PlanoConta> PlanoConta { get; set;}
        public DbSet<Transacao> Transacao { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=BOOK-MI1S91O1MG\SQLEXPRESS;Database=myFinance;Trusted_Connection=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

