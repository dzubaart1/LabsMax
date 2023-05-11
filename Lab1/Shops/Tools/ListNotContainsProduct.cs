namespace Shops.Tools
{
    internal class ListNotContainsProduct : Exception
    {
        public ListNotContainsProduct()
            : base("Лист не содержит продуктов")
        {
        }
    }
}
