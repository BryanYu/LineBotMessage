using LineBotMessageAPI.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;

namespace LineBotMessageAPI.Infrastructure;

public class ApplicationContext: DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
        
    }
    
    public DbSet<Product> Products { get; set; }
    
    
}