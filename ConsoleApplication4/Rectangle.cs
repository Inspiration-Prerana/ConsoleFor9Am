using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Rectangle
    {
        private decimal _length;
        private decimal _breadth;
        public decimal Area {
            get { return this._breadth * this._length; }
        }
        public Rectangle(decimal Length, decimal breadth)
        {
            this._length = Length >= 768 ? 768 : (Length<0?0:Length);
            this._breadth = breadth >= 1376 ? 1376 : (breadth<0?0:breadth);
        }
        
    }
}
