using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class ImpInter
    {
        protected string Data;
        public string data
        {
            get
            {
                return this.Data;
            }
            set
            {
                this.Data = value;
            }
        }
    }
    interface IOblivion
    {
        bool Validate();
    }
    class MyControl : ImpInter, IOblivion
    {
        public MyControl()
        {
            data = "my grid data";
        }
        public bool Validate()
        {
            Console.WriteLine("Validating...{0}", data);
            return true;
        }
    }
    class MyClass :IOblivion
    {
        private string str = "My class";
        public bool Validate()
        {
            Console.WriteLine("Validating from "+str);
            return true;
        }
    }
}