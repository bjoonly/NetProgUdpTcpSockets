namespace ClassLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class MyDbContext : DbContext
    {

        public MyDbContext()
            : base("name=MyDbContext")
        {
            Database.SetInitializer(new Initializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Exchange>().HasMany(e => e.ExchangeRatesFrom)
            .WithRequired(e => e.ExchangeFrom).HasForeignKey(e => e.ExchangeFromId)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<Exchange>().HasMany(e => e.ExchangeRatesTo)
            .WithRequired(e => e.ExchangeTo).HasForeignKey(e => e.ExchangeToId)
            .WillCascadeOnDelete(false);
        }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Exchange> Exchanges { get; set; }
        public virtual DbSet<ExchangeRate> ExchangeRates { get; set; }
        public virtual DbSet<Client> Clients { get; set; }


    }

    public class Log
    {
       
        public int Id { get; set; }
        public int ClientId { get; set; } 
        public int ExcangeRateId { get; set; }
        public DateTime ConntectionTime { get; set; }
        public DateTime ShutdownTime { get; set; }
        public virtual Client Client { get; set; }
        [ForeignKey(nameof(ExcangeRateId))]
        public virtual ExchangeRate ExchangeRate { get; set; }
    }
    public class Exchange
    {
        public Exchange()
        {
            ExchangeRatesFrom = new HashSet<ExchangeRate>();
            ExchangeRatesTo = new HashSet<ExchangeRate>();

        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<ExchangeRate> ExchangeRatesFrom { get; set; }
        public ICollection<ExchangeRate> ExchangeRatesTo { get; set; }

    }
    public class ExchangeRate
    {

        public ExchangeRate()
        {
            Logs = new HashSet<Log>();
        }
        public int Id { get; set; }
        public int ExchangeFromId { get; set; }
        public int ExchangeToId { get; set; }

        public decimal Rate { get; set; }
        public Exchange ExchangeFrom { get; set; }
        public Exchange ExchangeTo { get; set; }
        public ICollection<Log> Logs { get; set; }


    }
    public class Client
    {
        public Client()
        {
            Logs = new HashSet<Log>();
        }
        public int Id { get; set; }
        [Required]
        public string Login { get; set; }
        
        public string Password { get; set; }

        public ICollection<Log> Logs { get; set; }
    }
}