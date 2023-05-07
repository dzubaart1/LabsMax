﻿namespace Shops.Entities
{
    // уникальный идентификатор
    // название
    // адрес
    // товар
    public class Shop
    {
        public Shop(string name, string аddress)
        {
            Id = IdGenerator.GenerateId();
            Name = name;
            Аddress = аddress;
            Warehouse = new Warehouse();
            Money = 1000000;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Аddress { get; private set; }
        public Warehouse Warehouse { get; private set; }
        public double Money { get; private set; }

        public void RegisterProduct(Product product)
        {
            Warehouse.RegisterProduct(product);
        }

        public void Delivery(ProductDict productDict)
        {
            if (productDict == null || productDict.GetCount() == 0)
            {
                throw new NullDictException();
            }

            if (Money - productDict.GetPrice() < 0)
            {
                throw new NotEnoughMoneyException();
            }

            Warehouse.Delivery(productDict);
            Money -= productDict.GetPrice();
        }

        public bool ContainsProduct(Product product)
        {
            return Warehouse.ContainsProduct(product);
        }

        public int ProductCount(Product product)
        {
            return Warehouse.ProductCount(product);
        }
    }
}

// тест на создание магазинов, на доставку