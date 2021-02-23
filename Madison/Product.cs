using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madison
{
    class Product
    {
        protected double salesPrice;
        protected double factoryPrice;
        protected string productName;

        public Product(string name, double price, double cost)

        {

            productName = name;
            factoryPrice = price;
            salesPrice = price;

           
    }

    }
   
}
