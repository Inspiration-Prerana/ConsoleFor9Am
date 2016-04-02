using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Computer;

namespace ConsoleApplication4
{
    class Program
    {
        static CustomQueue cs = new CustomQueue(16);

        static CustomQueueTemplates<int> cInt = new CustomQueueTemplates<int>();
        static CustomQueueTemplates<string> cString = new CustomQueueTemplates<string>();

        static void Main(string[] args)
        {

            //cs.Enqueue(1);
            //cs.Enqueue(2);
            //DisplayResult();

            //Console.ReadLine();
            //cs.Dequeue();
            //DisplayResult();
            InitiateInheritence();
            Console.ReadLine();
        }

        static void InitiateInheritence()
        {
            SaburLal s = new SaburLal();
            Pramod p = new Pramod();
            Prakash _p = new Prakash();
            SonaLal Grandpaa = new SonaLal();

            Console.WriteLine(Grandpaa.ToString());
            Console.WriteLine(s.ToString());
            Console.WriteLine(_p.ToString());
            Console.WriteLine(p.ToString());
            //s.Call();
            //p.Call();
            //_p.Call();

            //p.Name();
            //_p.Name();

        }

        static void DisplayResult()
        {
            foreach (var item in cs.GetItems())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
