using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using BigMammaUML3.Models;
using BigMammaUML3.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BigMammaUML3.Pages.MenuItems
{
    public class EditMenuItemModel : PageModel
    {
        private MenuCatalog _menuCatalog;

        public EditMenuItemModel(MenuCatalog menuCatalog)
        {
            _menuCatalog = menuCatalog;
        }

        private MenuItem _searchedItem;
        private Pizza _pizza;
        private Beverage _beverage;
        [BindProperty] public bool SpecialCondition { get; set; }


        [Display(Name = "Nr:")]
        [Required(ErrorMessage = "Der skal indtastes et nummer")]
        [BindProperty]
        public int Number { get; set; }


        [Display(Name = "Navn:")]
        [Required(ErrorMessage = "Der skal indtastes et navn"), MaxLength(20)]
        [BindProperty]
        public string Name { get; set; }

        [Display(Name = "Beskrivelse:")]
        [Required(ErrorMessage = "Der skal indtastes en beskrivelse"), MaxLength(80)]
        [BindProperty]
        public string Description { get; set; }

        [Display(Name = "Pris:")]
        [Required(ErrorMessage = "Der skal indtastes en pris")]
        [BindProperty]
        public double Price { get; set; }

        public IActionResult OnGet(int id)
        {
            _searchedItem = _menuCatalog.Search(id);
            if (_searchedItem != null)
            {
                if (_searchedItem is Pizza)
                {
                    _pizza = (Pizza) _searchedItem;
                    SpecialCondition = _pizza.DeepPan;
                    Number = _pizza.Number;
                    Name = _pizza.Name;
                    Description = _pizza.Description;
                    Price = _pizza.Price;
                }
                else if (_searchedItem is Beverage)
                {
                    _beverage = (Beverage) _searchedItem;
                    SpecialCondition = _beverage.Alcohol;
                    Number = _beverage.Number;
                    Name = _beverage.Name;
                    Description = _beverage.Description;
                    Price = _beverage.Price;
                }
            }
            else
            {
                throw new AccessViolationException();
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (_searchedItem is Pizza)
            {
                _pizza.DeepPan = SpecialCondition;
                _pizza.Name = Name;
                _pizza.Description = Description;
                _pizza.Price = Price;
                _menuCatalog.Update(_searchedItem.Number, _pizza);
            }
            else if (_searchedItem is Beverage)
            {
                _beverage.Alcohol = SpecialCondition;
                _beverage.Name = Name;
                _beverage.Description = Description;
                _beverage.Price = Price;
                _menuCatalog.Update(_searchedItem.Number, _beverage);
            }
            return RedirectToPage("GetAllMenuItems");
        }
    }

}
