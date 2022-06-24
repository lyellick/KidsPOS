using KidsPOS.Common.Context;
using KidsPOS.Common.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace KidsPOS.Web.Site.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly KidsPOSContext _context;

        public Product[] Products { get; set; }

        public IndexModel(ILogger<IndexModel> logger, KidsPOSContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToArrayAsync();
        }
    }
}