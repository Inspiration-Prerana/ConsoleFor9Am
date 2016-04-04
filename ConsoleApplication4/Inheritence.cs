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
            this.FirstName = "Sona";
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
    public class Sabur:SonaLal
    {
        public string MidName;
        public Sabur()
        {
            this.FirstName = "Sabur";
            this.MidName = "Lal";
        }
        public void Call()
        {
            Console.WriteLine("Father");
        }
        public override string ToString()
        {
            return this.FirstName + " "+this.MidName+" " + this.LastName;
        }
    }

    public sealed class Pramod : Sabur
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
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }

    public class Prakash : Sabur
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
