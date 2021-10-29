using System;
using System.Collections.Generic;
using System.Text;

namespace ISpeak
{
    class Dog : ISpeak
    {
        public string Speak()
        {
            return "Woof";
        }
    }
}
