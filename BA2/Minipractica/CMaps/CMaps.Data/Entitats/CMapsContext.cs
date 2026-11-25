using Microsoft.EntityFrameworkCore;

namespace Minipractica.Entitats;

public class CMapsContext : DbContext
{
    public static string RutaSqlite => Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
        "CMaps.db");

    
    public DbSet<LlocPublic> LlocsPublics { get; set; }
    public DbSet<Usuari> Usuaris { get; set; }
    public DbSet<Ressenya> Ressenyes { get; set; }
    public DbSet<Zona> Zones { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder
                // OPCIÓ A: SQLite (no cal instal·lar res)
                .UseSqlite(@"Data Source=escola.db")
                // OPCIÓ B: SQL Server LocalDB (comenta la línia de dalt i descomenta aquesta)
                // .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EscolaEF;Trusted_Connection=True;")
                //Activar modo Lazy Loading
                .UseLazyLoadingProxies();
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        //FLUENT API

        modelBuilder.Entity<Usuari>() //Entity es tabla
            .HasIndex(u => u.NomUsuari) //property es columna
            // En algunos casos se pone .HasIndex y en otros se pone .Property
            .IsUnique();

        modelBuilder.Entity<Usuari>()
            .HasIndex(u => u.Email)
            .IsUnique();


        modelBuilder.Entity<Ressenya>()
            .HasIndex(r => new { r.UsuariId , r.LlocId}) 
            // El "new {*}" crea un objeto anónimo para agrupar varias propiedades
            
            
    .IsUnique();

        
        
        
        base.OnModelCreating(modelBuilder);
    }
}
