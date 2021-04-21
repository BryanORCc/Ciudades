using Ciudades.Models;
using Microsoft.EntityFrameworkCore;

namespace Ciudades.Data
{
    public class CiudadesContext : DbContext
    {
        public DbSet<Ciudad> Ciudades {get; set;}
        
        public CiudadesContext(DbContextOptions dco) : base(dco){
            
        }
    }
}