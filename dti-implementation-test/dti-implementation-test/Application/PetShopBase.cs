namespace Application
{
    public abstract class PetshopBase : IPetshop
    {
        protected PetshopBase(
            string name,
            double distance,
            Input input)
        {
            Name = name;
            Distance = distance;

            SetAmount(input);
        }

        public string Name { get; }

        public double Distance { get; }

        public decimal Amount { get; internal set; }

        protected abstract void SetAmount(Input input);

        public override string ToString() => $"{Name} ({Distance}m) - Total: {Amount:C}";
    }
}
