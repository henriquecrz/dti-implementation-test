namespace dti_implementation_test.Application
{
    public class ChowChawgas : PetShop
    {
        public const decimal SMALL_DOGS_BATH_PRICE = 30;
        public const decimal LARGE_DOGS_BATH_PRICE = 45;

        public ChowChawgas(string name, double distance, Input input) : base(name, distance)
        {
            SetAmount(input);
        }

        public override void SetAmount(Input input)
        {
            Amount = (input.SmallDogs * SMALL_DOGS_BATH_PRICE) + (input.LargeDogs * LARGE_DOGS_BATH_PRICE);
        }
    }
}
