﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interfaces
{
    interface IObserver
    {
        void Notify(AbstractPizza piz);
    }
}
