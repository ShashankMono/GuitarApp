using GuitarApp.Constants;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace GuitarApp.Models
{
    internal class Guitar
    {
        private string _serialNumber;
        private double _price;
        private GuitarFeatures _features;

        public Guitar(string serialN,double price,GuitarFeatures feature)
        {
            _serialNumber = serialN;
            _price = price;
            _features = feature;
        }

       public string GetSerialNumber()
        {
            return _serialNumber;
        }

        public double GetPrice()
        {
            return _price;
        }
        public void SetPrice(double price)
        {
            _price = price;
        }
        public GuitarFeatures GetFeatures() { 
            return _features;
        }
    }
}
