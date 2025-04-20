using AsyncDemo.Models;
using System.Collections.Concurrent;

namespace AsyncDemo.Services
{
    public class ProductService
    {
        private readonly ILogger<ProductService> _logger;
        private readonly ConcurrentDictionary<int, Product> _cashe = new();
        public ProductService(ILogger<ProductService> logger)
        {
            _logger = logger;
        }

        public async Task<Product> FetchFromApiAysnc(int ProductId, CancellationToken cancellationToken)
        {
            await Task.Delay(1000, cancellationToken);
            return new Product(ProductId, $"ProductId-{ProductId}",9.00m);
        }

        public async ValueTask<Product> GetProductAsync(int productId, CancellationToken cancellationToken)
        {
            if (_cashe.TryGetValue(productId, out var cached))
            {
                _logger.LogInformation("Cache HIT for product {ProductId}", productId);
                return cached;
            }

            _logger.LogInformation("Cache MISS - Fetching from API for product {ProductId}", productId);
            var product = await FetchFromApiAysnc(productId, cancellationToken);
            _cashe[productId] = product;
            return product;
        }
        
    }
}
