using CKK.Logic.Models;

namespace Unit_Tests_
{
    public class UnitTest1
    {
        [Fact]
        public void AddingProduct()
        {


            Customer Ricky = new Customer();
            Product product = new Product();
            ShoppingCart shoppingCartTest = new ShoppingCart(Ricky);
            Assert.Equal(shoppingCartTest.AddProduct(product), shoppingCartTest.GetProduct(1));


        }
        [Fact]
        public void RemoveProductTest()
        {
            Customer Ricky = new Customer();
            Product product = new Product();
            Product product2 = new Product();
            product.SetId(1);
            product2.SetId(2);
            ShoppingCart shoppingCartTest = new ShoppingCart(Ricky);
            shoppingCartTest.AddProduct(product, 2);
            shoppingCartTest.AddProduct(product2, 3);
            shoppingCartTest.RemoveProduct(product2, 2);

            Assert.Equal(1, shoppingCartTest.GetProduct(2).GetQuantity());
        }
        [Fact]
        public void GettingTotalTest()
        {
            Customer Ricky = new Customer();
            Product product = new Product();
            Product product2 = new Product();
            Product product3 = new Product();
            product.SetId(1);
            product2.SetId(2);
            product3.SetId(3);
            product.SetPrice((decimal)2.50);
            product2.SetPrice((decimal)3.00);
            product3.SetPrice((decimal)2.00);
            ShoppingCart shoppingCartTest = new ShoppingCart(Ricky);
            shoppingCartTest.AddProduct(product, 2);
            shoppingCartTest.AddProduct(product2, 3);
            shoppingCartTest.AddProduct(product3, 1);
            decimal expected = product.GetPrice() * 2 + product2.GetPrice() * 3 + product3.GetPrice();
            Assert.Equal(expected, shoppingCartTest.GetTotal());
        }
    }
}