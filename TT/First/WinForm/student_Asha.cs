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
    public partial class student_Asha : Form
    {
        public student_Asha()
        {
            InitializeComponent();
        }

        private void student_Asha_Load(object sender, EventArgs e)
        {
           
        }
       /* public stu_asha stuDetails(stu_asha obj)
        {
            stu_asha x = obj;

            return x;
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            stu_asha obj = new stu_asha();
            obj.id =Convert.ToInt32( textBox1.Text);
            obj.Name = textBox2.Text;
            obj.Section = textBox3.Text;
            obj.Address = textBox4.Text;
             MessageBox.Show("Id: " + obj.id.ToString());
            /* MessageBox.Show(obj.Name.ToString());
             MessageBox.Show(obj.Section.ToString());
             MessageBox.Show(obj.Address.ToString());*/
            string str = "Student Details:\n" + "Id: " + obj.id.ToString() + "\nName: " + obj.Name.ToString() + "\nSection: " + obj.Section.ToString() + "\nAddress: " + obj.Address.ToString();
            MessageBox.Show(str);
        }
    }

}
