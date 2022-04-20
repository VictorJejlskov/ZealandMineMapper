using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class AbstractPizzaDecorator : AbstractPizza
    {
        public AbstractPizza Pizza { get; set; }
    }
}
