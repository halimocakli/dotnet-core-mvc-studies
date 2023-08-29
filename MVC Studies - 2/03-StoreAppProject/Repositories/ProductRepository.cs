using Entities.Models;
using Repositories.Contracts;

namespace Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context)
        {

        }

        public IQueryable<Product> GetAllProducts(bool trackChanges) => FindAll(trackChanges);
        public Product? GetProductById(int id, bool trackChanges)
        {
            return FindByCondition(p => p.ProductId.Equals(id), false);
        }
    }
}