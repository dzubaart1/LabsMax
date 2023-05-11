﻿namespace Shops.Models
{
    public static class IdGenerator
    {
        private static int _id;

        public static int GenerateId()
        {
            return ++_id;
        }
    }
}
