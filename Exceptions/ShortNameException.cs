using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class ShortNameException : Exception
    {
        public ShortNameException(string message = "The name must be longer than two characters. Please insert a name longer than two characters!") : base(message)
        {
        }

    }
}
