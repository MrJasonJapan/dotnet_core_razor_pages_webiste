using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesPizza.Pages;

public class ReactModel : PageModel
{
    private readonly ILogger<ReactModel> _logger;

    public ReactModel(ILogger<ReactModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

