using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace See_Sharp_Dynamic_Link_Library_3
{
    public class Singleton : ISingleton
    {
        public static ISingleton _instance=null;
        public ISingleton Instance()
        {
            if (_instance == null)
                _instance = new Singleton();
            return _instance;
        }
    }
}
