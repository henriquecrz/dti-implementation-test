using System;

namespace dti_implementation_test.Application
{
    class Input
    {
        private int _smallDogs;
        private int _largeDogs;
        private DateTime _date;

        // Make a constructor

        public bool IsParseSuccess { get; private set; } = false;

        public int SmallDogs { get => _smallDogs; }

        public int LargeDogs { get => _largeDogs; }

        public DateTime Date { get => _date; }

        public void SetSmallDogs(string smallDogs) => IsParseSuccess = int.TryParse(smallDogs, out _smallDogs);

        public void SetLargeDogs(string largeDogs) => IsParseSuccess = int.TryParse(largeDogs, out _largeDogs);

        public void SetDate(string date) => IsParseSuccess = DateTime.TryParse(date, out _date);
    }
}
