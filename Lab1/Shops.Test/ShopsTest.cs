using Shops.Entities;
using Shops.Models;
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

        var productDict = new ProductDict();
        productDict.RegisterProduct(productToothPaste);
        productDict.AddProduct(productToothPaste, 50);
        productDict.RegisterProduct(productMilk);
        productDict.AddProduct(productMilk, 100);

        shop.Delivery(productDict);

        Assert.Equal(50, shop.ProductCount(productToothPaste));
        Assert.Equal(100, shop.ProductCount(productMilk));
    }

    [Fact]
    public void Buy_ProductsWasBuyed()
    {
        var shopManager = new ShopManager();
        Shop shop = shopManager.Create("Pyaterochka", "Pushkina28");
        var productToothPaste = new Product(140, "Toothpaste");
        var productMilk = new Product(80, "Milk");

        shopManager.RegisterProduct(productToothPaste);
        shopManager.RegisterProduct(productMilk);

        var productDict = new ProductDict();
        productDict.RegisterProduct(productToothPaste);
        productDict.AddProduct(productToothPaste, 50);
        productDict.RegisterProduct(productMilk);
        productDict.AddProduct(productMilk, 100);

        shop.Delivery(productDict);
        double shopMoneyBefore = shop.Money;

        var customerDict = new ProductDict();
        customerDict.RegisterProduct(productToothPaste);
        customerDict.AddProduct(productToothPaste, 2);
        customerDict.RegisterProduct(productMilk);
        customerDict.AddProduct(productMilk, 3);
        var customer = new Сustomer("name", 1000, customerDict);
        double customerMoneyBefore = customer.Money;

        shop.Buy(customer);

        Assert.Equal(48, shop.ProductCount(productToothPaste));
        Assert.Equal(97, shop.ProductCount(productMilk));
        Assert.Equal(shopMoneyBefore + customerDict.GetPrice(), shop.Money);
        Assert.Equal(customerMoneyBefore - customerDict.GetPrice(), customer.Money);
    }
}