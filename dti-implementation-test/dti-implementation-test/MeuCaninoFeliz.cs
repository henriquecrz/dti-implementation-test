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



        public MeuCaninoFeliz(string name, double distance, Input input) : base(name, distance)
        {
            SetAmount(input);
        }

        public void SetAmount(Input input)
        {
            _amount = (input.SmallDogs * SMALL_DOGS_BATH_PRICE) + (input.LargeDogs * LARGE_DOGS_BATH_PRICE);

            if (input.Date.DayOfWeek == DayOfWeek.Saturday || input.Date.DayOfWeek == DayOfWeek.Sunday)
            {
                _amount *= (decimal)1.2;
            }
        }
    }
}
