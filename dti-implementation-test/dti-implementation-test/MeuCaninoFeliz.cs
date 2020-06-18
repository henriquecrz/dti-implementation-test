using System;
using System.Collections.Generic;
using System.Text;

namespace dti_implementation_test
{
    class MeuCaninoFeliz : PetShop
    {
        private string _name;
        private double _distance;
        private decimal _amount;

        public const decimal SMALL_DOGS_BATH_PRICE = 20;
        public const decimal LARGE_DOGS_BATH_PRICE = 40;



        public MeuCaninoFeliz(string name, double distance) : base()
        {

        }

        public override void SetAmount(int smalldogs, int largedogs, DateTime date)
        {
            _amount = (smalldogs * SMALL_DOGS_BATH_PRICE) + (largedogs * LARGE_DOGS_BATH_PRICE);

            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                _amount *= (decimal)1.2;
            }
        }
    }
}
