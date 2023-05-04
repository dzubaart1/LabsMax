namespace Shops.Entities
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
            Money = 0;
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

        public void Delivery(ProductDict dict)
        {
            if (dict != null)
            {
                foreach (var kvp in dict._)
            }
        }
    }
}
