﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BigMamaPizzaStore
{
    class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Customer(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Kunde: {Name}, {Age}";
        }
    }
}
