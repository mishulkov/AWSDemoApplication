using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AWSDemoApplication.Pages
{
    public class IndexModel : PageModel
    {
        public DateTime CurrentTime { get; set; } = DateTime.Now;

        public void OnGet()
        {

        }
    }
}
