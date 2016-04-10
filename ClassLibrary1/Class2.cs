using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public enum Division
    {
        Distinction,
        FirstDivision,
        SecondDivision,
        ThirdDivision,
        Fail,
        NotAvailable

    }

    /// <summary>
    /// 
    /// </summary>
    public class Students
    {
        #region Propoerties
        private string studentName;
        private int roll;
        private List<Subject> subject;
        private float total;
        private float totalFull;
        private float percentage;
        private Division division;
        #endregion

        #region Constructors
        public Students(string studentname, int rollnum, List<Subject> sub)
        {
            this.studentName = studentname;
            this.roll = rollnum;
            this.subject = sub;
            Calucation();
        }
        public Students(int rollnum, List<Subject> sub)
        {
            this.roll = rollnum;
            this.subject = sub;
            Calucation();
        }
        public Students(List<Subject> sub)
        {
            this.subject = sub;
            Calucation();
        }
        #endregion

        #region Private Members
        private void Calucation()
        {
            total = 0;
            totalFull = 0;
            ////foreach item 
            //foreach (var item in subject)
            //{
            //    total += item.AchievedMarks;
            //    totalFull += item.FullMarks;
            //}

            ////for  loop 
            //for (int i = 0; i < subject.Count; i++)
            //{
            //    total += subject[i].AchievedMarks;
            //    totalFull += subject[i].FullMarks;
            //}

            //do loop 
            int i = 0;
            do
            {
                total += subject[i].AchievedMarks;
                totalFull += subject[i].FullMarks;
                i++;
            } while (i < subject.Count);

            percentage = (total / totalFull) * 100;
            GetDivision();
        }
        private void GetDivision()
        {
            if (percentage < 32)
            {
                this.division = ClassLibrary1.Division.Fail;
            }
            else if (percentage < 45)
            {
                this.division = ClassLibrary1.Division.ThirdDivision;
            }
            else if (percentage < 60)
            {
                this.division = ClassLibrary1.Division.SecondDivision;
            }
            else if (percentage < 80)
            {
                this.division = ClassLibrary1.Division.FirstDivision;
            }
            else if (percentage <= 100)
            {
                this.division = ClassLibrary1.Division.Distinction;
            }
            else
            {
                this.division = ClassLibrary1.Division.NotAvailable;
            }
        }

        #endregion

        #region Public Accessors
        public float Total
        {
            get { return this.total; }
        }
        public float Percentage
        {
            get { return this.percentage; }
        }
        public Division Division
        {
            get { return this.division; }
        }

        #endregion

        #region Destructors
        ~Students()
        {

        }
        #endregion
    }

    public class Subject
    {
        private string subjectName;
        private float theoryMarks;
        private float practicalMarks;
        private float fullMarks;
        private DateTime UpdatedDate;
        public string SubjectName
        {
            get {
                return this.subjectName;
            }
            set {
                UpdatedDate = DateTime.Now;
                subjectName = value;
            }
        }
        public float TheoryMarks
        {
            get { return this.theoryMarks; }
            set { theoryMarks = value; }
        }
        public float PracticalMarks
        {
            get { return this.practicalMarks; }
            set { practicalMarks = value; }
        }

        public float FullMarks
        {
            get { return this.fullMarks; }
            set { fullMarks = value; }
        }
        public float AchievedMarks
        {
            get { return this.theoryMarks + this.practicalMarks; }
        }
    }
}
