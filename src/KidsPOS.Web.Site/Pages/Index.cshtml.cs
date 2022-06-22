using KidsPOS.Common.Context;
using KidsPOS.Common.Models;
using KidsPOS.Web.Site.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace KidsPOS.Web.Site.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AppSettings _settings;
        private readonly KidsPOSContext _context;

        public Product[] Products { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IOptions<AppSettings> options, KidsPOSContext context)
        {
            _logger = logger;
            _settings = options.Value;
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToArrayAsync();
        }
    }
}