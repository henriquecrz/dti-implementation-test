using Utils;

namespace Application
{
    public class MeuCaninoFelizPetshop : PetshopBase
    {
        public const decimal SMALL_DOG_BATH_PRICE = 20;
        public const decimal LARGE_DOG_BATH_PRICE = 40;

        public MeuCaninoFelizPetshop(string name, double distance, Input input) :
            base(name, distance, input)
        {

        }

        protected override void SetAmount(Input input)
        {
            Amount =
                input.SmallDogs * SMALL_DOG_BATH_PRICE +
                input.LargeDogs * LARGE_DOG_BATH_PRICE;

            if (input.Date.IsWeekend())
            {
                Amount *= (decimal)1.2;
            }
        }
    }
}
