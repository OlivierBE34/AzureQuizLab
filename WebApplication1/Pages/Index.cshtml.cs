using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        public bool MaintenanceMode { get; set; }

        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration _configuration;

        public IndexModel(ILogger<IndexModel> logger, IConfiguration config)
        {
            _logger = logger;
            _configuration = config;
        }
        public void OnGet()
        {
            MaintenanceMode = _configuration.GetValue<bool>("MaintenanceMode", false);
        }
    }
}
