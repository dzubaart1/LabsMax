namespace Shops.Entities
{
    public class ShopManager
    {
        private List<Shop> _shops;

        public ShopManager()
        {
            _shops = new List<Shop>();
        }

        public delegate void RegisterProductDelegate(Product product);
        public event RegisterProductDelegate? UpdateRegisterProduct;

        public Shop Create(string name, string аddress)
        {
            var shop = new Shop(name, аddress);
            UpdateRegisterProduct += shop.RegisterProduct;
            _shops.Add(shop);
            return shop;
        }

        public void RegisterProduct(Product product)
        {
            UpdateRegisterProduct?.Invoke(product);
        }

        public int ShopsCount()
        {
            return _shops.Count;
        }

        public bool ContainsProduct(Product product)
        {
            return _shops[0].ContainsProduct(product);
        }
    }
}
