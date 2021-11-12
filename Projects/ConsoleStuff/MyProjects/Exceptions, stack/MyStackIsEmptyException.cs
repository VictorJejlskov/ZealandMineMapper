using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions__stack
{
    class MyStackIsEmptyException:Exception
    {
        public MyStackIsEmptyException(string message) : base(message)
        {
            
        }
    }
}
