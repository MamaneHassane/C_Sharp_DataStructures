using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_DataStructures
{
    class Node<T>
    {
        public Node(T value)
        {
            this.Value = value;
        }
        public Node()
        {
            Value = default;
        }
        // La valeur dans le noeud
        public T? Value { get; set; }
        // Le noeud suivant
        public Node<T>? Next { get; set; }

        // Fonction pour afficher le noeud
        public override string ToString()
        {
            return Next is null ?  $"{Value} " : $"{Value} --> ";
        }
    }
}
