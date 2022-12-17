using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageInfo.Pages.Products;

namespace RazorPageInfo.Pages.Categories
{
    public class CategoryPageModel : PageModel
    {
        public async Task<IActionResult> OnGet()
        {
            return Redirect("/product");
        }
    }
}
