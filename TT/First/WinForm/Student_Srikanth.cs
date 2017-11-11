using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Student_Srikanth : Form
    {
        public Student_Srikanth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//main function
            WinStudent_Srikanth1 obj = new WinStudent_Srikanth1();
            obj.Id =Convert.ToInt32( textBox1.Text);
            obj.Name = textBox2.Text;
            obj.section = Convert.ToChar(textBox3.Text);

            string res = "Student details are:\n " + "Id= " + obj.Id + "Name=" + obj.Name + "section=" + obj.section;


            Student_Srikanth form = new Student_Srikanth();
            form.Show();

            MessageBox.Show(res);

        }
        public WinStudent_Srikanth1 Students1(WinStudent_Srikanth1 a)
        {

            WinStudent_Srikanth1 result;
            result = a;
            return result;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
