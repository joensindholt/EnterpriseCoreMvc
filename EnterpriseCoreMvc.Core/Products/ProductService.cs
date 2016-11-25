using System;
using System.Collections.Generic;

namespace EnterpriseCoreMvc.Core.Products
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Delete(int productId)
        {
            _productRepository.Delete(productId);
        }

        public Product Get(int productId)
        {
            return _productRepository.Get(productId);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public void Save(Product product)
        {
            _productRepository.Save(product);
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }
    }
}