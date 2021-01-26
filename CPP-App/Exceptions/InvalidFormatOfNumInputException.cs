using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP_App.Exceptions
{
    class InvalidFormatOfNumInputException:Exception
    {
        public InvalidFormatOfNumInputException()
        {

        }

        public InvalidFormatOfNumInputException(string message):base("Invalid"+message)
        {

        }
    }

    
}
