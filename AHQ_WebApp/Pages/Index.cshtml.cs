using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;

namespace RazorPagesIntro.Pages
{
    public class Index2Model : PageModel
    {
        public string Name => (string)TempData[nameof(Name)];

        public string Message { get; private set; } = "PageModel in C#";

        public void OnGet()
        {
            Message += $" Server time is { DateTime.Now }";
        }

        /* // Form submissions */
        public IActionResult OnPost([FromForm]string name)
        {
            TempData["Name"] = name;
            /* Message += $" Here's the name { name }"; */
            return RedirectToPage("Index");
        }
    }
}
