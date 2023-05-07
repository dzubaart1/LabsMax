namespace Shops.Entities
{
    internal class ListNotContainsProduct : Exception
    {
        public ListNotContainsProduct()
            : base("Лист не содержит продуктов")
        {
        }
    }
}
