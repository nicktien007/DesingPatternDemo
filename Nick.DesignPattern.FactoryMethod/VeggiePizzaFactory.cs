﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nick.DesignPattern.SimpleFactory;

namespace Nick.DesignPattern.FactoryMethod
{
    class VeggiePizzaFactory: IPizzaFactory
    {
        public Pizza CreatePizza()
        {
            return new VeggiePizza();
        }
    }
}
