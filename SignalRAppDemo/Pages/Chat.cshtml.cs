using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;

namespace SignalRAppDemo.Pages
{
    public class ChatModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public ChatModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
