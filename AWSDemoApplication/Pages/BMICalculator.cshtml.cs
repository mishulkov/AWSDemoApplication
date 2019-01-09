using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AWSDemoApplication.Pages
{
    public class BMICalculatorModel : PageModel
    {
        [TempData]
        public string ResultInfo { get; set; }

        [Required]
        [BindProperty]
        public int Weight { get; set; }

        [Required]
        [BindProperty]
        public int Height { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            float result = await BMIApi.CalculateBMI(Weight, Height);

            if (result < 18.5)
            {
                ResultInfo = $"Underweight (BMI: {result})";
            }
            else if (result < 23)
            {
                ResultInfo = $"Normal weight (BMI: {result})";
            }
            else if (result < 25)
            {
                ResultInfo = $"Overweight - At Risk (BMI: {result})";
            }
            else if (result < 30)
            {
                ResultInfo = $"Overweight - Moderately Obese (BMI: {result})";
            }
            else
            {
                ResultInfo = $"Overweight - Severely Obese (BMI: {result})";
            }

            return Page();
        }
    }
}
