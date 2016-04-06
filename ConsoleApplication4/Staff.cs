using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Staff
    {
        protected string Name;

        public Staff(string name)
        {
            this.Name = name;
        }

        public string name
        {
            get { return this.Name; }
        }

        virtual public void ComputePay()
        {
            Console.WriteLine("Staff.ComputePay called for {0}", name);
        }
    }

    public class ContractStaff : Staff
    {
        public ContractStaff(string name)
        : base(name)
        {
        }
        public override void ComputePay()
        {
            Console.WriteLine("ContractStaff.ComputePay called for {0}", name);
        }
    }
    public class SalariedStaff : Staff
    {
        public SalariedStaff(string name)
        : base(name)
        {
        }
        public override void ComputePay()
        {
            Console.WriteLine("SalariedStaff.ComputePay called for {0}", name);
        }
    }
    public class polymorphism
    {
        protected Staff[] Staffs;
        public void LoadStaffs()
        {
            // Simulating loading from a database.
            Staffs = new Staff[2];
            Staffs[0] = new ContractStaff("Mike scott");
            Staffs[1] = new SalariedStaff("Patrick");
        }
        public void DoPayroll()
        {
            foreach (Staff emp in Staffs)
            {
                emp.ComputePay();
            }
        }
    }
}
