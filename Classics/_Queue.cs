using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_DataStructures.Classics
{
    class _Queue<T>
    {
        // Le tête de la file
        Node<T>? Head { get; set; } = new Node<T>();
        // Le queue de la file
        Node<T>? Tail { get; set; } = new Node<T>();
        // La taille de la file 
        private int Size { get; set; } = 0;

        public _Queue()
        {
            Head = Tail;
        }

        // Fonction pour savoir si la file est vide
        public bool Empty()
        {
            return Size == 0;
        }

        // Fonction pour afficher la file
        public override string ToString()
        {
            if (Empty())
            {
                return "La file est vide.";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("{ HEAD ");
                Node<T>? node = Head;
                while (node is not null)
                {
                    sb.Append(node.ToString());
                    node = node.Next;
                }
                sb.Append(" TAIL }\n");
                return sb.ToString();
            }
        }

        // Fonction pour ajouter un élément à la queue
        public void Push(T value)
        {
            if (Empty())
            {
                Head = Tail = new Node<T>(value);
            }
            else
            {
                Node<T> node = Tail;
                while (node is not null)
                {
                    node = node.Next;
                }
                node = new Node<T>(value);
                Tail.Next = node;
                Tail = node;
            }
            Size++;
        }

        // Fonction pour rétirer un élément de la queue
        public void Pop()
        {
            if (Head == Tail)
            {
                Head.Value = Tail.Value = default;
            }
            else
            {
                Node<T>? node = Head;
                Head = Head.Next;
                node = null;
            }
            Size--;
        }
    }
}
