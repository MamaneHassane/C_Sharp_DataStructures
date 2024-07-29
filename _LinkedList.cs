using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_DataStructures
{
    class _LinkedList<T>
    {
        // Le noeud initial
        Node<T> Node;
        // La taille de la liste
        int Size { get; set; } = 0;

        // Fonction pour connaître la taille de la liste
        public int Count()
        {
            return Size;
        }

        // Fonction pour connaître la taille de la liste
        public bool Empty()
        {
            return Size == 0;
        }

        // Fonction pour afficher la liste
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Empty())
                return "La liste est vide";
            else
            {
                sb.Append("{ ");
                int count = 0;
                if (Size==1)
                    sb.Append(Node.ToString());
                else
                {
                    Node<T>? node = Node;
                    while (node is not null && count < Size)
                    {
                        sb.Append(node.ToString());
                        node = node.Next;
                        count++;
                    }
                }
                sb.Append(" }");
                return sb.ToString();
            }
        }

        // Fonction pour ajouter un élément à la liste
        public void Add(T value)
        {
            if(Empty())
            {
                Node = new(value);
            }
            else
            {
                Node<T> node = Node;
                while (node.Next is not null)
                {
                    node = node.Next;
                }
                node.Next = new(value);
            }
            Size++;
        }

        // Fonction pour trouver un élément de la liste par son index
        public T? Get(int index) 
        {
            if (index < 0 || index >= Size)
            {
                // Index hors limites
                throw new IndexOutOfRangeException();
            }
            // Si l'index est égal à 0
            int count = 0;
            if(index == count) return Node.Value;
            Node<T>? node = Node;
            while (node.Next is not null && count < Size)
            {
                if (count == index) return node.Value;
                node = node.Next;
                count++;
            }
            // Sinon c'est le dernier élément
            return node.Value;
        }

        // Fonction pour trouver l'index d'un élément de la liste par sa valeur
        public int GetIndexOf(T? value)
        {
            int count = 0;
            Node<T>? node = Node;
            while (node is not null && count < Size)
            {
                if (node.Value.Equals(value)) return count;
                node = node.Next;
                count++;
            }
            throw new Exception("La valeur spécifiée n'est pas dans la liste");
        }

        // Fonction pour retirer un élément de la liste par son index
        public bool Remove(int index)
        {
            if (index < 0 || index >= Size)
            {
                // Index hors limites
                throw new IndexOutOfRangeException();
            }
            int count = 0;
            // Si l'index est égal à 0
            if(index == count)
            {
                Node<T>? toDelete = Node;
                Node = Node.Next;
                toDelete = null;
                Size--;
                return true;
            }
            Node<T>? node = Node;
            while (node.Next is not null && count + 1 < Size)
            {
                if (count + 1 == index) 
                {
                    Node<T>? toDelete = node.Next;
                    node.Next = node.Next.Next;
                    toDelete = null;
                    return true;
                } 
                node = node.Next;
                count++;
            }
            // L'index est égal à la taille
            node = null;
            Size--;
            return true;
        }

        // Fonction pour retirer l'index d'un élément de la liste par sa valeur
        public bool RemoveValue(T? value)
        {
            // Trouver l'index
            int index = GetIndexOf(value);
            // Supprimer par index pour ne pas repéter du code
            return Remove(index);            
        }
    }
}

