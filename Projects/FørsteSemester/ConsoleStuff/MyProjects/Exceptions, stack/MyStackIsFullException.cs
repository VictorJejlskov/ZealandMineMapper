using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions__stack
{
    class MyStackIsFullException : Exception
    {
        public MyStackIsFullException(string message) : base(message)
        {
            
        }
    }
}
