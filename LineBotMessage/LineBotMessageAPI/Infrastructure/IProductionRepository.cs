using LineBotMessageAPI.Infrastructure.Model;

namespace LineBotMessageAPI.Infrastructure;

public interface IProductionRepository : IRepository<Product>
{
    Task<IEnumerable<Product>> GetProductsByPriceAsync(decimal minimumPrice);
}