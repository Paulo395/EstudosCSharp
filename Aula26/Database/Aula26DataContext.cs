using Aula26.Data.Mappings;
using Aula26.Models.Usuario;
using Microsoft.EntityFrameworkCore;

namespace Aula26.Data;

public class Aula26DataContext : DbContext
{
    public DbSet<Usuario> Usuarios{ get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options){
        options.UseSqlServer(@"Data
Source=usinacompany.com;User ID=usina_usr;Password=Abc54321;Connect
Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");//String de conecção Classrom
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.ApplyConfiguration(new UsuarioMap());
    }
    //Conecção com bando de dados realizada!    
}