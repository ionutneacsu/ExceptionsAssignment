using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class OverAgeLimitException : Exception
    {
        public OverAgeLimitException(string message = "The age is greather than 100 years. Please insert correct age!") : base(message)
        {
        }
    }
}
