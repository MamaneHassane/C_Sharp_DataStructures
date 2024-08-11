using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_DataStructures.Binary_Search_Tree
{
    class TreeNode<T>
    {
        // La valeur contenue dans le noeud
        public T Value;
        // Le fils gauche, valeur inférieure
        public TreeNode<T> Left { get; set; }
        // Le fils droit, valeur supérieure
        public TreeNode<T> Right { get; set; }

        public TreeNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
