namespace Shops.Tools
{
    public class NullDictException : Exception
    {
        public NullDictException()
            : base("Пустой лист")
        {
        }
    }
}
