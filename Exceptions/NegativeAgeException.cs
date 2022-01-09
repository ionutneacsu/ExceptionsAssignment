using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class NegativeAgeException : Exception
    {
        public NegativeAgeException(string message ="The age cannot be negative. Please insert a positive number! ") : base(message)
        {
        }
    }
}
