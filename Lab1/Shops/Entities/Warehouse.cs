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
    }
}