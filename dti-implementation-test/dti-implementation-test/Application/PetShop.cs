namespace dti_implementation_test.Application
{
    public abstract class PetShop : IPetShop
    {
        protected PetShop(string name, double distance)
        {
            Name = name;
            Distance = distance;
        }

        public string Name { get; set; }

        public double Distance { get; set; }

        public decimal Amount { get; set; }

        public abstract void SetAmount(Input input);
    }
}
