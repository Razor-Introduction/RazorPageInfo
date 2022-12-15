using RazorPageInfo.DataAccess.Context;
using RazorPageInfo.Models;

namespace RazorPageInfo.DataAccess
{
    public class ProductDal: EfEntityRepositoryBase<Product, RazorInfoContext>, IProductDal
    {
    }
}
