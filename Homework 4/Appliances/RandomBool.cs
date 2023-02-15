using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_Appliances
{
    static class RandomBool
    {
        public static bool Get(int i)
        {
            Random rnd = new Random();
            return rnd.Next(i) == 0;
        }
    }
}
