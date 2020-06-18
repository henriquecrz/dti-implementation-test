using System;

namespace dti_implementation_test
{
    class MeuCaninoFeliz : PetShop
    {
        public const decimal SMALL_DOGS_BATH_PRICE = 20;
        public const decimal LARGE_DOGS_BATH_PRICE = 40;

        public MeuCaninoFeliz(string name, double distance, Input input) : base(name, distance)
        {
            SetAmount(input);
        }

        public void SetAmount(Input input)
        {
            Amount = (input.SmallDogs * SMALL_DOGS_BATH_PRICE) + (input.LargeDogs * LARGE_DOGS_BATH_PRICE);

            if (input.Date.DayOfWeek == DayOfWeek.Saturday || input.Date.DayOfWeek == DayOfWeek.Sunday)
            {
                Amount *= (decimal)1.2;
            }
        }
    }
}
