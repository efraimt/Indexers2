using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers2
{
    public class Entity {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Student:Entity
    {
      
        public int Age { get; set; }
        public int Grade { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class StudentManagament
    {
        Student[] students = new Student[1000];

        public void AddStudent(Student student) {
            students[Count++] = student;
        }

        public void AddStudent(int id, string name  )
        {
            students[Count++] = new Student() { Id=id, Name=name};
        }

        public void RemoveStudent() {
        
        }
        public int Count { get; set; }

        public Student? GetStudentById(int id)
        {
            for (int i = 0; i < Count; i++)
            {
                if (students[i].Id == id) return students[i];

            }
            return null;
        }

        public Student? GetStudentByName(string name)
        {
            for (int i = 0; i < Count; i++)
            {
                if (students[i].Name == name) return students[i];

            }
            return null;
        }

        //public Student this[int i] => GetStudentById(i);
        public Student this[string name]
        {
            get
            {
                return GetStudentByName(name);
            }
        }

        public Student[] this[int grade]
        {
            get
            {
                int i = 0;
                Student[] bestStudents = new Student[1000];
                foreach (var student in students)
                {
                    if (student.Grade > grade)
                    {
                        bestStudents[i] = student;
                        i++;
                    }
                }
                return bestStudents;
            }
        }


    }

    public class Sidra
    {
        public int this[int j]
        {
            get
            {
                int x = 1;
                //Debug.WriteLine(x);
                for (int i = 0; i < j; i++)
                {
                    x += 2;
                    //Debug.WriteLine(x);
                    
                }
                return x;
            }
        }
    }

}
