using LaKeyDiVolta.Models;
using Microsoft.EntityFrameworkCore;

namespace LaKeyDiVolta.Data
{
    public class DataContext : DbContext
    {
        

        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {

        }
        
        /*
                Questo metodo sovrascritto, essenziale per passare i parametri del db server
                è stato semplificato all'interno del file Program.cs in ASP.NET 6
            
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("...");
        }
        
        */

        //Queste sono le tabelle, avendo all'interno di ciascuno di questi singoli modelli una lista di elementi
        //dell'altro modello, SQL Server genererà una tabella di mezzo delle due relazioni 1-N (Una relazione N-N)
        public DbSet<Videogame> Videogames { get; set; } 
        public DbSet<User> Users { get; set; } 


    }
}
