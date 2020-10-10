namespace dti_implementation_test.Application
{
    public interface IPetShop
    {
        string Name { get; set; }

        double Distance { get; set; }

        decimal Amount { get; set; }

        void SetAmount(Input input);
    }
}
