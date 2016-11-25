﻿using System.Collections.Generic;

namespace EnterpriseCoreMvc.Core.Products
{
    public interface IProductService
    {
        void Save(Product product);

        Product Get(int productId);

        void Update(Product product);

        void Delete(int productId);

        IEnumerable<Product> GetAll();
    }
}