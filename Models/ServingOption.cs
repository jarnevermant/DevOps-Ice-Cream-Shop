using Contentful.Core.Models;

namespace IceCreamShopContentful.Models
{
    public class ServingOption
    {
        public string Name { get; set; }
        public Asset Image { get; set; }
        public float Price { get; set; }
        public bool ShownOnWebsite { get; set; }
    }
}
