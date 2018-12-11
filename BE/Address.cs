using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public struct Address
    {
        public string street, city;
        public int buildingNumber;

        public Address(string _street, string _city, int _buildingNumber)
        {
            street = _street;
            city = _city;
            buildingNumber = _buildingNumber;
        }        
    }
}
