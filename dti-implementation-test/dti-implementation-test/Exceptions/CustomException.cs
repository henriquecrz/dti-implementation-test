using System;
using System.Collections.Generic;
using System.Text;

namespace dti_implementation_test.Exceptions
{
    class CustomException : Exception
    {
        public CustomException(string message) : base(string.Format("Invalid Student Name: {0}", message))
        {

        }
    }
}
