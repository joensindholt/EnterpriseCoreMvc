using EnterpriseCoreMvc.Core.Products;
using System.Collections.Generic;
using System.Linq;

namespace EnterpriseCoreMvc.Database
{
    public class ProductRepository : IProductRepository
    {
        private DatabaseContext _db;

        public ProductRepository(DatabaseContext db)
        {
            _db = db;
        }

        public Product Get(int productId)
        {
            var product = _db.Products.First(p => p.Id == productId);
            return product;
        }

        public IEnumerable<Product> GetAll()
        {
            var products = _db.Products;
            return products;
        }

        public void Save(Product product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
        }

        public void Update(Product product)
        {
            _db.Products.Update(product);
            _db.SaveChanges();
        }

        public void Delete(int productId)
        {
            var product = _db.Products.First(p => p.Id == productId);
            _db.Remove(product);
            _db.SaveChanges();
        }
    }
}