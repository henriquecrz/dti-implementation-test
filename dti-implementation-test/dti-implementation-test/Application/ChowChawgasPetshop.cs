namespace Application
{
    public class ChowChawgasPetshop : PetshopBase
    {
        public const decimal SMALL_DOGS_BATH_PRICE = 30;
        public const decimal LARGE_DOGS_BATH_PRICE = 45;

        public ChowChawgasPetshop(string name, double distance, Input input) :
            base(name, distance, input)
        {

        }

        protected override void SetAmount(Input input)
        {
            Amount =
                input.SmallDogs * SMALL_DOGS_BATH_PRICE +
                input.LargeDogs * LARGE_DOGS_BATH_PRICE;
        }
    }
}
