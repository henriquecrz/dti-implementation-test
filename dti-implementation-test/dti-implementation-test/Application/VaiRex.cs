using dti_implementation_test.Utils;

namespace dti_implementation_test.Application
{
    public class VaiRex : PetShop
    {
        public const decimal SMALL_DOGS_BATH_PRICE_WEEKDAY = 15;
        public const decimal LARGE_DOGS_BATH_PRICE_WEEKDAY = 50;
        public const decimal SMALL_DOGS_BATH_PRICE_WEEKEND = 20;
        public const decimal LARGE_DOGS_BATH_PRICE_WEEKEND = 55;

        public VaiRex(string name, double distance, Input input) : base(name, distance)
        {
            SetAmount(input);
        }

        public override void SetAmount(Input input)
        {
            decimal smallDogs;
            decimal largeDogs;

            if (input.Date.IsWeekend())
            {
                smallDogs = SMALL_DOGS_BATH_PRICE_WEEKEND;
                largeDogs = LARGE_DOGS_BATH_PRICE_WEEKEND;
            }
            else
            {
                smallDogs = SMALL_DOGS_BATH_PRICE_WEEKDAY;
                largeDogs = LARGE_DOGS_BATH_PRICE_WEEKDAY;
            }

            Amount = (input.SmallDogs * smallDogs) + (input.LargeDogs * largeDogs);
        }
    }
}
