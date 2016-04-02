using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class SonaLal
    {
        public string LastName;
        public string FirstName;
        public SonaLal()
        {
            this.LastName = "Phanait";
            this.FirstName = "Sona Lal";
        }

        public override string ToString()
        {
            return this.FirstName+" "+this.LastName;
        }
    }
    public class SaburLal:SonaLal
    {
        
        public SaburLal()
        {
            this.FirstName = "Sabur Lal";
        }
        public void Call()
        {
            Console.WriteLine("Father");
        }
        
    }

    public class Pramod : SaburLal
    {
        //public string FirstName;
        public Pramod()
        {
            this.FirstName = "Pramod";
        }
        public void Name()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName);
        }
        public void Call()
        {
            Console.WriteLine("Younger Son");
        }
       
    }

    public class Prakash : SaburLal
    {
        //public string FirstName;
        public Prakash()
        {
            this.FirstName = "Prakash";
        }
        public void Name()
        {
            Console.WriteLine(this.FirstName+" "+this.LastName);
        }
        public void Call()
        {
            Console.WriteLine("Elder Son.");
        }
       
    }
}
