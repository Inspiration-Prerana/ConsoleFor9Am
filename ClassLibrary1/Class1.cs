using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary1.Math;
namespace ClassLibrary1
{
    /// <summary>
    /// This is class 1.
    /// </summary>
    public class Class1
    {
        public int i;
        private int j;

        /// <summary>
        /// Constructor with 0 paramters
        /// </summary>
        public Class1()
        {
            i = 0;
            j = 0;
        }

        /// <summary>
        /// Constructor with 1 parameter 
        /// </summary>
        /// <param name="i">Integer for the constuctor</param>
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
