using Microsoft.EntityFrameworkCore;

namespace Licenta.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    // Deocamdată gol – adăugăm tabele imediat
}