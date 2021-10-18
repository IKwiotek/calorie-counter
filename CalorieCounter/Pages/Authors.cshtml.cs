using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalorieCounter.Pages
{
    public class AuthorsModel : PageModel
    {
        private readonly ILogger<AuthorsModel> _logger;

        public AuthorsModel(ILogger<AuthorsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
