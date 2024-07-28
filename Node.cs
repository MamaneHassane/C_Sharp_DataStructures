using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_DataStructures
{
    class Node<T> (T value) 
    {

        // La valeur dans le noeud
        private T? Value = value;
        // Le noeud suivant
        private Node<T>? Next { get; set; }

        // Fonction pour afficher le noeud
        public override string ToString()
        {
            return $"{Value} --> ";
        }
    }
}
