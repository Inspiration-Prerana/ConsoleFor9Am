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
            //InitiateInheritence();

            //Polymorph();

            //InterfaceImp();

            ExceptionFunc();
            Console.ReadLine();
            
        }

        static void ExceptionFunc()
        {
            List<string> stringlist = new List<string>();
            test1class t = new test1class();
            try
            {
                
                t.string1 = "string1";
                Console.WriteLine(t.string1);

                stringlist.Add("123awdfa");

                //t.str = stringlist;
                //t.str1.Add("123");

                foreach (var item in t.str)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.ToString());
                if (ex.Message.Contains("Object reference not set to an instance of an object."))
                {
                    Console.WriteLine("Object not created. Trying to create a new object.");
                    t.str = stringlist;
                    
                }
                else
                {
                    Console.WriteLine("We are sorry to inform you that we also dont know what crashed the system. :("); 
                }
            }
            finally
            {
                foreach (var item in t.str)
                {
                    Console.WriteLine(item);
                }
            }
        }

        static void Polymorph()

        {
            polymorphism p = new polymorphism();
            p.LoadStaffs();
            p.DoPayroll();
        }

        static void InterfaceImp()
        {
            MyControl myControl = new MyControl();
            IOblivion val = (IOblivion)myControl;
            bool success = val.Validate();
            Console.WriteLine("The validation of '{0}' was {1}successful",
            myControl.data,
            (true == success ? "" : "not "));

            MyClass mycls = new MyClass();
            val = (IOblivion)mycls;
            bool mybool = val.Validate();
        }

        static void InitiateInheritence()
        {
            Sabur s = new Sabur();
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
            Rectangle r = new Rectangle(0, 0);
            
            Console.WriteLine("Area is : " + r.Area);
            
            Console.WriteLine("Area is : "+r.Area);
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
