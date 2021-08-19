using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers2
{
    public class StudentsLinkedList
    {
        private class Node
        {
            public Student? Data { get; set; }
            public Node? Next { get; set; }

            public override string ToString()
            {
                return "Node " + Data.Name; 
            }
        }

        private Node? head = null;

        //public Student First()
        //{ 

        //}

        public void Add(Student student)
        {
            //if (student == null) throw new ArgumentNullException("");


            if (head == null)
            {
                Node node = new Node() { Data = student, Next = null };
                head = node;
            }
            else
            {
                Node node = head;
                while (node.Next !=null)
                {
                    node=node.Next;
                }
                
                node.Next=new Node() { Data = student, Next = null };
                

            }
        }

    }
}
