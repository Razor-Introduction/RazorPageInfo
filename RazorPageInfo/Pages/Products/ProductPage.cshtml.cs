using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageInfo.Models;
using RazorPageInfo.Services;

namespace RazorPageInfo.Pages.Products
{
    public class ProductPageModel : PageModel
    {
        private readonly IProductService _productService;

        public ProductPageModel(IProductService productService)
        {
            _productService = productService;
        }

        public Product Product { get; set; }

        [BindProperty]
        public IEnumerable<Product> Products { get; set; }

        public Category Category { get; set; }
        public List<Category> Categories { get; set; }

        #region Onget
        public async Task<IActionResult> OnGet()
        {
            var getProducts = await _productService.GetAll();
            Products = getProducts;
            return Page();
        }
        #endregion

        #region OnGetProducts
        public async Task<IActionResult> OnGetProducts()
        {
            throw new NullReferenceException();
        }
        #endregion

        #region OnPost
        public async Task<IActionResult> OnPost()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region OnPostSave
        public async Task<IActionResult> OnPostSave()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
