using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class Milk:Product
    {
        private int _volume;
        private int _fatrate;

        public int Volume { get { return _volume; } set { _volume = value; } }
        public int Fatrate { get { return _fatrate; } set { _fatrate = value; } }
    }
}
