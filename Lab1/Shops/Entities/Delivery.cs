namespace Shops.Entities
{
    public class Delivery
    {
        private ProductDict _productDict;
        public Delivery(Dictionary<Product, int> dict)
        {
            _productDict = new ProductDict(dict);
        }
    }
}
