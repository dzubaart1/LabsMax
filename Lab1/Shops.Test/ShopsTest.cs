using Shops.Entities;
using Xunit;

namespace Shops.Test;

public class ShopsTest
{
    [Fact]
    public void CreateShop_ShopManagerContainsShop()
    {
        var shopManager = new ShopManager();
        shopManager.Create("Pyaterochka", "Pushkina28");
        Assert.Equal(1, shopManager.ShopsCount());
    }

    [Fact]
    public void RegisterProduct_ShopHaveRegisteredProduct()
    {
        var shopManager = new ShopManager();
        shopManager.Create("Pyaterochka", "Pushkina28");
        var product = new Product(140, "Toothpaste");
        shopManager.RegisterProduct(product);
        Assert.True(shopManager.ContainsProduct(product));
    }

    [Fact]
    public void Delivery_ShopHaveDeliveredProduct()
    {
        var shopManager = new ShopManager();
        Shop shop = shopManager.Create("Pyaterochka", "Pushkina28");
        var productToothPaste = new Product(140, "Toothpaste");
        var productMilk = new Product(80, "Milk");
        shopManager.RegisterProduct(productToothPaste);
        shopManager.RegisterProduct(productMilk);
        var deliveryList = new Dictionary<Product, int>()
        {
            { productToothPaste, 50 },
            { productMilk, 100 },
        };

        var productDict = new ProductDict(deliveryList);
        shop.Delivery(productDict);
        Assert.Equal(50, shop.ProductCount(productToothPaste));
        Assert.Equal(100, shop.ProductCount(productMilk));
    }
}