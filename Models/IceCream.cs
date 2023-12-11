using Contentful.Core.Models;

namespace IceCreamShopContentful.Models
{
    public class IceCream
    {
        public string Flavor { get; set; }
        public List<string> ServingOptions { get; set; }
        public Asset Image { get; set; }
        public bool ShownOnWebsite { get; set; }
    }
}
