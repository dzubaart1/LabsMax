namespace Shops.Tools
{
    public class NotEnoughMoneyException : Exception
    {
        public NotEnoughMoneyException()
            : base("Не хватает денег")
        {
        }
    }
}
