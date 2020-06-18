using System;
using System.Collections.Generic;
using System.Text;

namespace dti_implementation_test
{
    class VaiRex : Petshop
    {
        private string _name;
        private double _distance;
        private decimal _amount;

        public const decimal SMALL_DOGS_BATH_PRICE = 15;
        public const decimal LARGE_DOGS_BATH_PRICE = 50;
        public const decimal SMALL_DOGS_BATH_PRICE_WEEKEND = 15;
        public const decimal LARGE_DOGS_BATH_PRICE_WEEKEND = 50;



        public VaiRex(string name, double distance) : base(name, distance)
        {

        }

        public override void SetAmount(int smalldogs, int largedogs, DateTime date)
        {
            _amount = (smalldogs * SMALL_DOGS_BATH_PRICE) + (largedogs * LARGE_DOGS_BATH_PRICE);

            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                _amount = (smalldogs * SMALL_DOGS_BATH_PRICE_WEEKEND) + (largedogs * LARGE_DOGS_BATH_PRICE_WEEKEND);
            }
        }
    }
}
