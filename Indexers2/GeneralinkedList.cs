using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Indexers2
{

    

    public class GeneralLinkedList<TData> where TData : Entity
    {
        private class Node
        {
            public TData Data { get; set; }
            public Node? Next { get; set; }

            public override string ToString()
            {
                return "Node " ; 
            }
        }

        private Node? head = null;

        //public Student First()
        //{ 

        //}

        public void Add(TData data)
        {
            //if (student == null) throw new ArgumentNullException("");


            if (head == null)
            {
                Node node = new Node() { Data = data, Next = null };
                head = node;
            }
            else
            {
                Node node = head;
                while (node.Next !=null)
                {
                    node=node.Next;
                }
                
                node.Next=new Node() { Data = data, Next = null };
                

            }
        }

        public TData First => head.Data;


        public TData GetById(int id)
        {
            Node node = head;
            while (node.Next != null)
            {
                if (node.Data.Id == id) return node.Data;
                node = node.Next;
            }

        }

    }
}
