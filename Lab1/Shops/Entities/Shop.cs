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
            Products = new List<Product>();
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Аddress { get; private set; }
        public List<Product> Products { get; private set; }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
    }
}
