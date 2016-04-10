using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class StudentsTests
    {
        
        [TestMethod]
        public void StudentTesting()
        {
            List<Subject> sub = new List<Subject>();
            for (int i = 0; i < 4; i++)
            {
                Subject sb = new Subject();
                sb.FullMarks = 100;
                sb.SubjectName = i.ToString();
                sb.TheoryMarks = 20;
                sb.PracticalMarks = 2;
                sub.Add(sb);
            }

            Students st = new Students(sub);
            Assert.AreEqual(ClassLibrary1.Division.Fail, st.Division,ClassLibrary1.Division.Fail.ToString()+" "+st.Division.ToString()+" Are not equal");
           
        }


        
    }
}