using Utils;

namespace Application
{
    public class VaiRexPetshop : PetshopBase
    {
        public const decimal SMALL_DOG_BATH_PRICE_WEEKDAY = 15;
        public const decimal LARGE_DOG_BATH_PRICE_WEEKDAY = 50;
        public const decimal SMALL_DOG_BATH_PRICE_WEEKEND = 20;
        public const decimal LARGE_DOG_BATH_PRICE_WEEKEND = 55;

        public VaiRexPetshop(string name, double distance, Input input) :
            base(name, distance, input)
        {

        }

        protected override void SetAmount(Input input)
        {
            decimal smallDogs;
            decimal largeDogs;

            if (input.Date.IsWeekend())
            {
                smallDogs = SMALL_DOG_BATH_PRICE_WEEKEND;
                largeDogs = LARGE_DOG_BATH_PRICE_WEEKEND;
            }
            else
            {
                smallDogs = SMALL_DOG_BATH_PRICE_WEEKDAY;
                largeDogs = LARGE_DOG_BATH_PRICE_WEEKDAY;
            }

            Amount =
                input.SmallDogs * smallDogs +
                input.LargeDogs * largeDogs;
        }
    }
}
