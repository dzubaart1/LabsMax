namespace Shops.Entities
{
    // деньги
    // покупка
    public class Сustomer
    {
        public Сustomer(string name, double moneyBefore, ProductDict productDict)
        {
            Name = name;
            Money = moneyBefore;
            ProductDict = productDict;
        }

        public double Money { get; private set; }
        public string Name { get; private set; }
        public ProductDict ProductDict { get; private set; }
    }
}
