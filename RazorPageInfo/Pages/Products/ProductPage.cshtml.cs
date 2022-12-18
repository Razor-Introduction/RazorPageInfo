using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        [BindProperty]
        public Product Product { get; set; }

        [BindProperty]
        public IEnumerable<Product> Products { get; set; }

        [BindProperty]
        public Category Category { get; set; }
        [BindProperty]

        public List<Category> Categories { get; set; }

        [BindProperty]
        public List<SelectListItem> ProductList { get; set; }

        #region Onget
        public async Task<IActionResult> OnGet()
        {
            var getProducts = await _productService.GetAll();
            Products = getProducts.OrderByDescending(x => x.Id);
            await BindProducts();
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
        //public async Task<IActionResult> OnPost(Product product)
        //{
        //    await _productService.Add(product);
        //    return Redirect("/product");
        //}
        #endregion

        #region OnPostSave
        public async Task<IActionResult> OnPostSave(Product product)
        {
            await _productService.Add(product);
            return Redirect("/product");
        }
        #endregion

        #region OnPostSaveProduct
        public async Task<JsonResult> OnPostSaveProduct(string name, int stock, string color)
        {
            Product product = new();
            product.Name = name;
            product.Stock = stock;
            product.Color = color;
            await _productService.Add(product);
            return new JsonResult(product);
        }
        #endregion

        #region SelectProduct
        public async Task BindProducts()
        {
            var productList = await _productService.GetAll();

            ProductList.Add(new SelectListItem() { Value = "0", Text = "--ÜRÜN SEÇ--", Selected = true });
            ProductList = productList.Select(a => new SelectListItem
            {
                Value = (a.Id).ToString(),
                Text = a.Name,
            }).ToList();
            
        }
        #endregion
    }
}
