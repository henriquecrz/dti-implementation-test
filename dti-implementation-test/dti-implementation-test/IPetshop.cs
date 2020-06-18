using System;

namespace dti_implementation_test
{
    interface IPetshop
    {
        string Name { get; set; }

        double Distance { get; set; }

        decimal Amount { get; }

        //void SetAmount(int smallDogs, int largeDogs, DateTime date);
    }
}
