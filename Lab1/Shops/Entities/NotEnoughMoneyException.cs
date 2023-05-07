namespace Shops.Entities
{
    public class NotEnoughMoneyException : Exception
    {
        public NotEnoughMoneyException()
            : base("Не хватает денег")
        {
        }
    }
}
