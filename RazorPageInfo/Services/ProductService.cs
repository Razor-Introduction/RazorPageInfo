using RazorPageInfo.DataAccess;
using RazorPageInfo.Models;

namespace RazorPageInfo.Services
{
    public class ProductService: IProductService
    {
        IProductDal _productDal;

        public ProductService(IProductDal productService)
        {
            _productDal = productService;
        }

        public async Task Add(Product product)
        {
            await _productDal.Add(product);
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            var getProducts = await _productDal.GetList();
            return getProducts;
        }

        public async Task<Product> GetById(int id)
        {
            var getProduct = await _productDal.Get(x => x.Id == id);
            return getProduct;
        }

        public async Task Update(Product product)
        {
            await _productDal.Update(product);
        }
    }
}
