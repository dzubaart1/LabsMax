namespace Shops.Entities
{
    // деньги
    // покупка
    public class Сustomer
    {
        public Сustomer(Dictionary<Product, int> dict)
        {
            ProductList = new ProductDict(dict);
        }

        public double Money { get; private set; }
        public ProductDict ProductList { get; private set; }
    }
}
