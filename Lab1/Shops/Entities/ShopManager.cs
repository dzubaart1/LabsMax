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

        public void Create(string name, string аddress)
        {
            var shop = new Shop(name, аddress);
            UpdateRegisterProduct += shop.RegisterProduct;
            _shops.Add(shop);
        }

        public void RegisterProduct(Product product)
        {
            UpdateRegisterProduct?.Invoke(product);
        }
    }
}
