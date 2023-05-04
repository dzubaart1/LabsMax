namespace Shops.Entities
{
    // Цена
    // Количество
    public class Product
    {
        public Product(int price, string name)
        {
            Price = price;
            Name = name;
        }

        public int Price { get; private set; }
        public string Name { get; private set; }
    }
}