﻿namespace Shops.Entities
{
    public class NullDictException : Exception
    {
        public NullDictException()
            : base("Пустой лист")
        {
        }
    }
}
