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
    public partial class StudentsWithList : Form
    {
        public StudentsWithList()
        {
            InitializeComponent();
        }

        int count = 1;
        StudentsLinkedList list = new StudentsLinkedList();


        //GeneralLinkedList    list2 = new GeneralLinkedList();

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                Name = "Student" + (count++).ToString()
            };
            list.Add(student);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //var student = (Student)list2.First;


            //list2.Add(new ObsoleteAttribute());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GeneralLinkedList<Student> studentsList= new GeneralLinkedList<Student>();
            studentsList.Add(new Student());

            //GeneralLinkedList<int> intList= new GeneralLinkedList<int>();
            //intList.Add(5);

        }
    }
}
