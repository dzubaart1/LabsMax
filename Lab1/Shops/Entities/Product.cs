namespace Shops.Entities
{
    // Цена
    // Количество
    public class Product
    {
        public Product(int price, int amount)
        {
            Price = price;
            Amount = amount;
        }

        public int Price { get; private set; }
        public int Amount { get; private set; }
    }

}
