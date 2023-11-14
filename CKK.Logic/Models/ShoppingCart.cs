using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        private Customer? _customer;
        private ShoppingCartItem? _product1;
        private ShoppingCartItem? _product2;
        private ShoppingCartItem? _product3;
        public ShoppingCart(Customer cust)
        {
           _customer = cust;
        }
        public int GetCustomerId()
        {
            return _customer.GetId();
        }
        public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
            ShoppingCartItem item = new ShoppingCartItem(prod, quantity);
            if (quantity <= 0)
            {
                return null;
            }
            if (_product1 != null && _product1.GetProduct().GetId() == prod.GetId())
            {
              _product1.SetQuantity(_product1.GetQuantity() + quantity);
               return _product1;
            }
            if (_product2 != null && _product2.GetProduct().GetId() == prod.GetId())
            {
                _product2.SetQuantity(_product2.GetQuantity() + quantity);
                return _product2;
            }
            if (_product3 != null && _product3.GetProduct().GetId() == prod.GetId())
            {
                _product3.SetQuantity(_product3.GetQuantity() + quantity);
                return _product3;
            }
            if (_product1 == null)
            {
                _product1 = item;
                    return _product1;
            }
            if (_product2 == null)
            {
                _product2 = item;
                return _product2;
            }
            if (_product3 == null)
            {
                _product3 = item;
                return _product3;
            }
            return null;
            
        }
        public ShoppingCartItem AddProduct(Product prod)
        {
            return AddProduct(prod, 1);
           
        }
        public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {
            if (quantity > 0)
            {
                if (_product1.GetProduct().GetId() == prod.GetId() && _product1.GetQuantity() - quantity >= 0)
                {
                    _product1.SetQuantity(_product1.GetQuantity() - quantity);
                    if (_product1.GetQuantity() == 0)
                    {
                        _product1 = null;
                        
                    }
                    return _product1;
                }
                else if (_product2.GetProduct().GetId() == prod.GetId() && _product2.GetQuantity() - quantity >= 0)
                {
                    _product2.SetQuantity(_product2.GetQuantity() - quantity);
                    if (_product2.GetQuantity() == 0)
                    {
                        _product2 = null;


                    }
                    return _product2;
                }
                else if (_product3.GetProduct().GetId() == prod.GetId() && _product3.GetQuantity() - quantity >= 0)
                {
                    _product3.SetQuantity(_product3.GetQuantity() - quantity);
                    if (_product3.GetQuantity() == 0)
                    {
                        _product3 = null;


                    }
                    return _product3;
                }




            }
            return null;
        }
        public ShoppingCartItem GetProductById(int id)
        {
            if (id == _product1.GetProduct().GetId())
            {
                return _product1;
            }
            else if (id == _product2.GetProduct().GetId())
            {
                return _product2;
            }
            else if (id == _product3.GetProduct().GetId())
            {
                return _product3;
            }
            else return null;

        }
        public decimal GetTotal()
        {
            decimal product1Total = _product1.GetQuantity() * _product1.GetProduct().GetPrice();
            decimal product2Total = _product2.GetQuantity() * _product2.GetProduct().GetPrice();
            decimal product3Total = _product3.GetQuantity() * _product3.GetProduct().GetPrice();
            return product1Total + product2Total + product3Total;

        }
        public ShoppingCartItem GetProduct(int productNum)
        {
            if (productNum >= 1 && productNum <= 3)
            {
                switch (productNum)
                {
                    case 1:
                        return _product1;
                    case 2:
                        return _product2;
                    case 3:
                        return _product3;
                    default:
                        return null;
                }
            }
            else return null;
        }








    }
}
