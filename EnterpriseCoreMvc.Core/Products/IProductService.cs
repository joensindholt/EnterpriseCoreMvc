using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnterpriseCoreMvc.Core.Products
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllAsync();
    }
}