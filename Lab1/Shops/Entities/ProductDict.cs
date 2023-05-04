namespace Shops.Entities
{
    public class ProductDict
    {
        private Dictionary<Product, int> _products;
        public ProductDict()
        {
            _products = new Dictionary<Product, int>();
        }

        public ProductDict(Dictionary<Product, int> dict)
        {
            _products = dict;
        }

        public void RegisterProduct(Product product)
        {
            _products.Add(product, 0);
        }

        public double GerPrice()
        {
            double price = 0;
            foreach (Product item in _products.Keys)
            {
                int count = (int)_products.Values;
                price += item.Price;
            }
        }
    }
}
