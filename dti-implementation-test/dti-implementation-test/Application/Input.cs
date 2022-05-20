using System;

namespace Application
{
    public class Input
    {
        public Input(DateTime date, int smallDogs, int largeDogs)
        {
            Date = date;
            SmallDogs = smallDogs;
            LargeDogs = largeDogs;
        }

        public DateTime Date { get; }

        public int SmallDogs { get; }

        public int LargeDogs { get; }
    }
}
