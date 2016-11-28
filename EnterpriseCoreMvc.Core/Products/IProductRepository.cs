using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnterpriseCoreMvc.Core.Products
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
    }
}