using System.Collections;
using Shops.Models;

namespace Shops.Entities
{
    public class ProductDict : IEnumerable<KeyValuePair<Product, int>>
    {
        private Dictionary<Product, int> _products;
        public ProductDict()
        {
            _products = new Dictionary<Product, int>();
        }

        public void RegisterProduct(Product product)
        {
            _products.Add(product, 0);
        }

        public double GetPrice()
        {
            double price = 0;
            foreach (Product item in _products.Keys)
            {
                int count = _products[item];
                price += item.Price * count;
            }

            return price;
        }

        public int GetCount()
        {
            return _products.Count;
        }

        public bool ContainsKey(Product key)
        {
            return _products.ContainsKey(key);
        }

        public void AddProduct(Product product, int count)
        {
            _products[product] += count;
        }

        public void BuyProduct(Product product, int count)
        {
            _products[product] -= count;
        }

        public IEnumerator<KeyValuePair<Product, int>> GetEnumerator()
        {
            foreach (KeyValuePair<Product, int> item in _products)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
