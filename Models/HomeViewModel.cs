using Contentful.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace IceCreamShopContentful.Models
{
    public class HomeViewModel
    {
        public List<Flavor> Flavors { get; set; }
        public List<ServingOption> ServingOptions { get; set; }
        public List<Topping> Toppings { get; set; }
    }
}
