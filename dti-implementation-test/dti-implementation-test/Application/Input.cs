using System;

namespace dti_implementation_test.Application
{
    public class Input
    {
        public Input(DateTime date, int smallDogs, int largeDogs)
        {
            Date = date;
            SmallDogs = smallDogs;
            LargeDogs = largeDogs;
        }

        public DateTime Date { get; private set; }

        public int SmallDogs { get; private set; }

        public int LargeDogs { get; private set; }
    }
}
