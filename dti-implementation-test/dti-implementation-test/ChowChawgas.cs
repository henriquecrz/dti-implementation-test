using System;
using System.Collections.Generic;
using System.Text;

namespace dti_implementation_test
{
    class ChowChawgas : Petshop
    {
        private string _name;
        private double _distance;
        private decimal _amount;

        public const decimal SMALL_DOGS_BATH_PRICE = 30;
        public const decimal LARGE_DOGS_BATH_PRICE = 45;

        public ChowChawgas(string name, double distance) : base(name, distance)
        {

        }

        public override void SetAmount(int smalldogs, int largedogs, DateTime date)
        {
            _amount = (smalldogs * SMALL_DOGS_BATH_PRICE) + (largedogs * LARGE_DOGS_BATH_PRICE);
        }
    }
}
