using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private List<Subject> Sub { get; set; }
        private Students student { get; set; }
        public Form1()
        {
            InitializeComponent();
            Sub = new List<Subject>();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Subject s = new Subject();
            s.SubjectName = textBox3.Text;
            s.FullMarks = float.Parse(textBox4.Text);
            s.TheoryMarks = float.Parse(textBox5.Text);
            s.PracticalMarks = float.Parse(textBox6.Text);

            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            MessageBox.Show("Added Successfully !!! :)");

            Sub.Add(s);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            InputProcessing();
            Output();
        }

        private void InputProcessing()
        {
            student = new Students(textBox1.Text, int.Parse(textBox2.Text), this.Sub);

        }

        private void Output()
        {
            label5.Text = "Total = "+student.Total;
            label6.Text = "Percentage = "+student.Percentage+"%";
            label7.Text = student.Division+" Division";

        }
    }
}
