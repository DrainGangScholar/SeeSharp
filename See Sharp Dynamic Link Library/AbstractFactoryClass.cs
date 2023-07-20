﻿using See_Sharp_Dynamic_Link_Library_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace See_Sharp_Dynamic_Link_Library
{
    public class AbstractFactoryClass : IAbstractFactory
    {
        public ISingletonFactory SingletonFactory()
        {
            return new SingletonFactory(); 
        }
    }
}
