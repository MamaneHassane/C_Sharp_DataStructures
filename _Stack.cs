using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_DataStructures
{
    class _Stack<T>()
    {
        // Le sommet de la pile
        Node<T>? Top { get; set; } = new Node<T>();
        // La taille de la pile 
        private int Size { get; set; } = 0;

        // Fonction pour afficher la pile
        public override string ToString()
        {
            StringBuilder sb = new();
            if (Empty()) 
            {
                return "La pile est vide";
            }
            else
            {
                sb.Append("{ ");
                Node<T>? node = Top;
                while ( node != null)
                {
                    sb.Append(node.ToString());
                    node = node.Next;
                }
                sb.Append(" }\n");
                return sb.ToString();
            }
        }

        // Fonction pour connaître la taille de la pile
        public int Count()
        {
            return Size;
        }

        // Fonction pour savoir si la pile est vide
        public bool Empty()
        {
            return Size == 0;
        }

        // Fonction pour ajouter un noeud à la pile
        public void Push(T value)
        {
            Node<T>? node = Top;
            if (Size == 0) 
            {
                Top.Value = value;
            }
            else 
            {
            Top = new Node<T>(value)
            {
                Next = node
            };
            }
            // Incrémenter la taille
            Size++;
        }

        // Fonction pour retirer un noeud de la pile
        public void Pop()
        {
            if (Top is not null && Top.Value is not null)
            {
                Node<T>? node = Top;
                Top = Top.Next;
                node = null;
                // Décrémenter la taille
                if(Size<0) Size--;
            }
        }
        // Fonction pour retourner le sommet de la pile
        public T? Head()
        {
            if (Top is not null && Top.Value is not null)
            {
                return Top.Value;
            }
            return default;
        }
    }
}
