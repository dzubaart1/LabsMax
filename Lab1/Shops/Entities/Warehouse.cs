namespace Shops.Entities
{
    public class Warehouse
    {
        private ProductDict _products;

        public Warehouse()
        {
            _products = new ProductDict();
        }

        public void RegisterProduct(Product product)
        {
            _products.RegisterProduct(product);
        }

        public void Delivery(ProductDict productDict)
        {
            foreach (KeyValuePair<Product, int> item in productDict)
            {
                if (!_products.ContainsKey(item.Key))
                {
                    throw new ListNotContainsProduct();
                }

                _products.AddProduct(item);
            }
        }

        public void Buy(ProductDict productDict)
        {
            foreach (KeyValuePair<Product, int> item in productDict)
            {
                if (!_products.ContainsKey(item.Key))
                {
                    throw new ListNotContainsProduct();
                }

                _products.BuyProduct(item);
            }
        }

        public bool ContainsProduct(Product product)
        {
            return _products.ContainsKey(product);
        }

        public int ProductCount(Product product)
        {
            int i = 0;
            foreach (KeyValuePair<Product, int> item in _products)
            {
                if (item.Key == product)
                {
                    i = item.Value;
                }
            }

            return i;
        }
    }
}