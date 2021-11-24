using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BigMammaUML3.Models;
using BigMammaUML3.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BigMammaUML3.Pages.MenuItems
{
    public class CreateMenuItemModel : PageModel
    {
        [BindProperty] public int TypeID { get; set; }
        private MenuCatalog _menuCatalog;

        public CreateMenuItemModel(MenuCatalog menuCatalog)
        {
            _menuCatalog = menuCatalog;
        }

        [BindProperty] public bool SpecialCondition { get; set; }
        [Display(Name = "Nr:")]
        [Required(ErrorMessage = "Der skal indtastes et nummer")]
        [BindProperty] public int Number { get; set; }
        [Display(Name = "Navn:")]
        [Required(ErrorMessage = "Der skal indtastes et navn"), MaxLength(20)]
        [BindProperty] public string Name { get; set; }

        [Display(Name = "Beskrivelse:")]
        [Required(ErrorMessage = "Der skal indtastes en beskrivelse"), MaxLength(80)]
        [BindProperty] public string Description { get; set; }

        [Display(Name = "Pris:")]
        [Required(ErrorMessage = "Der skal indtastes en pris")]
        [BindProperty] public double Price { get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (TypeID == 1)
            {
                _menuCatalog.Add(new Pizza(SpecialCondition, Number, Name, Description, Price));
                return RedirectToPage("GetAllMenuItems");
            }
            _menuCatalog.Add(new Beverage(SpecialCondition, Number, Name, Description, Price));
            return RedirectToPage("GetAllMenuItems");
        }
    }
}
