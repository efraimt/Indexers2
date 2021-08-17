using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Indexers2
{
    public partial class Form1 : Form
    {
        StudentManagament students = new StudentManagament();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var student = students.GetStudentById(int.Parse(textBox1.Text));
            var student = students[int.Parse(textBox1.Text)];
            
            /*
             כאן מופיע קוד שמציג את הסטודנט אם מצאנו כזה סטודנט
             */

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var student = students[textBox5.Text];
            var student2 = students["משה"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int grade = 85;
            Student[] studendsArray = students[grade];
            DateTime dt = new DateTime(2000, 10, 29);
       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = new Sidra()[2];
            Debug.WriteLine(x);
            Debug.WriteLine(new Sidra()[5]);
        }
    }
}
