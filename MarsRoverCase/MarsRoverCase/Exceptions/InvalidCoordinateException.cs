using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverCase.Exceptions
{
    public class InvalidCoordinateException:Exception
    {
        public InvalidCoordinateException():base()
        {

        }
        public InvalidCoordinateException(string message) : base(message)
        {

        }
    }
}
