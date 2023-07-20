using See_Sharp_Dynamic_Link_Library_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace See_Sharp_Dynamic_Link_Library_2
{
    public class SingletonFactory : ISingletonFactory
    {
        public ISingleton CreateSingleton()
        {
            return new Singleton();
        }
    }
}
