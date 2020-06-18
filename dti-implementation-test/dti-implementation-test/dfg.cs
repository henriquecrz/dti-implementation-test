using System;
using System.Collections.Generic;
using System.Text;

namespace dti_implementation_test
{
    class PetShop : IPetShop
    {
        private string _name;
        private double _distance;
        private decimal _amount = 0;

        public PetShop(string name, double distance)
        {
            Name = name;
            Distance = distance;
        }

        public string Name { get => _name; set => _name = value; }

        public double Distance { get => _distance; set => _distance = value; }

        public decimal Amount { get => _amount; }
    }
}
