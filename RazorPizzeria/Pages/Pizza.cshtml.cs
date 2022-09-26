using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>
        {
            new PizzasModel 
            { 
                ImageTitle = "Margerita",
                PizzaName = "Margerita",
                BasePrice=2.0f, 
                TomatoSauce = true, 
                Cheese =true,
                FinalPrice = 3.5f
            },

            new PizzasModel 
            {
                ImageTitle = "Bolognese", 
                PizzaName = "Bolognese", 
                BasePrice=2.0f,
                TomatoSauce=true,
                Cheese=true,
                Beef=true,
                FinalPrice = 5f
            },

            new PizzasModel
            {
                ImageTitle = "Hawaiian",
                PizzaName = "Hawaiian",
                BasePrice=2.0f,
                Cheese=true,
                Chicken=true,
                Pineapple=true,
                FinalPrice = 4.5f
            },

            new PizzasModel
            {
                ImageTitle = "Carbonara",
                PizzaName = "Carbonara",
                BasePrice=2.0f,
                TomatoSauce=true,
                Cheese=true,
                Ham=true,
                FinalPrice = 4.0f
            },

            new PizzasModel
            {
                ImageTitle = "Pepperoni",
                PizzaName = "Pepperoni",
                BasePrice=2.0f,
                TomatoSauce=true,
                Cheese=true,
                Ham=true,
                Beef=true,
                FinalPrice = 5.5f
            },

            new PizzasModel
            {
                ImageTitle = "Seafood",
                PizzaName = "Seafood",
                BasePrice=2.0f,
                TomatoSauce=true,
                Cheese=true,
                Tuna=true,
                FinalPrice = 6f
            },

            new PizzasModel
            {
                ImageTitle = "Vegetarian",
                PizzaName = "Vegetarian",
                BasePrice=2.0f,
                TomatoSauce=true,
                Cheese=true,
                Mushroom=true,
                FinalPrice = 4.0f
            },
        };

        public void OnGet()
        {
        }
    }
}
