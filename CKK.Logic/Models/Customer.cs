using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
   public class Customer
    {
        private int id;
        private string name;
        private string address; 

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
        public string GetAddress()
        {
            return address;
        }
        public void SetAddress(string Address)
        {
            address = Address;
        }
        

    }
}
