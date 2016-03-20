using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary1.Math;
namespace ClassLibrary1
{
    public class Class1
    {
        public int i;
        private int j;

        //Constructor
        public Class1()
        {
            i = 0;
            j = 0;
        }

        public Class1( int i)
        {
            this.i = i;
            this.j = 0;
        }

        public Class1(int i, int j)
        {
            this.i = i;
            this.j = j;
        }

        //Methods
        public int Add()
        {
            //statements
            return i + j;
        } 
        //Destructors
    }

}
