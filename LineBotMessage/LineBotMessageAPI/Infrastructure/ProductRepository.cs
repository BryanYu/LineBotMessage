using LineBotMessageAPI.Infrastructure.Model;

namespace LineBotMessageAPI.Infrastructure;

public class ProductRepository : Repository<Product>, IProductionRepository
{
    public ProductRepository(ApplicationContext applicationContext) : base(applicationContext)
    {
    }

    public Task<IEnumerable<Product>> GetProductsByPriceAsync(decimal minimumPrice)
    {
        throw new NotImplementedException();
    }
}