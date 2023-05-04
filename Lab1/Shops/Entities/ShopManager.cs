namespace Shops.Entities
{
    public class ShopManager
    {
        private List<Shop> _shops;

        public ShopManager()
        {
            _shops = new List<Shop>();
        }

        public void AddShop(string name, string аddress)
        {
            var shop = new Shop(name, аddress);
            _shops.Add(shop);
        }

        public void RegisterProduct(Shop shop, Product product)
        {
            shop.RegisterProduct(product);
        }
    }
}
