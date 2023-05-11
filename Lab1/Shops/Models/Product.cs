namespace Shops.Models
{
    public class Product
    {
        public Product(double deliveryPrice, string name)
        {
            DeliveryPrice = deliveryPrice;
            Name = name;
        }

        public double DeliveryPrice { get; private set; }
        public double Price { get; private set; }
        public string Name { get; private set; }

        public void SetUpPrice(double upPrice)
        {
            Price = DeliveryPrice + (DeliveryPrice * upPrice);
        }
    }
}