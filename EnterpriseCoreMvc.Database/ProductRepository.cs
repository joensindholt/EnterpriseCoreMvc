using EnterpriseCoreMvc.Core.Products;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnterpriseCoreMvc.Database
{
    public class ProductRepository : IProductRepository
    {
        private DatabaseContext _db;

        public ProductRepository(DatabaseContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            var products = await _db.Products.ToListAsync();
            return products;
        }
    }
}