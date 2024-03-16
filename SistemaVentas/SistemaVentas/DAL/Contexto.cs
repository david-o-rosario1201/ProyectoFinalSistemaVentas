using Microsoft.EntityFrameworkCore;

namespace SistemaVentas.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
        
    }
}
