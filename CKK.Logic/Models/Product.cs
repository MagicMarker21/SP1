using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    internal class Product
    {
        private int id;
        private string name;
        private decimal price;

        public int GetId()
        {
            return id;
        }
        public void SetId(int Id)
        {
            id = Id;
        }
        public string GetName()
        {

            return name;
        }
        public void SetName(string Name)
        {
            name = Name;
        }
        public decimal GetPrice()
        {
            return price;
        }
        public void SetPrice(decimal Price)
        {
            price = Price;
        }
    }
}
