using C_Sharp_DataStructures.Binary_Search_Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_DataStructures.Binary_Search_Tree
{
    class _BinarySearchTree<T>
    {
        // La racine de l'arbre
        public TreeNode<T>? Root { get; set; }
        // La taille de l'arbre
        public int Size { get; set; } = 0;

        // Fonction pour afficher la taille de l'arbre
        public int Count()
        {
            return Size;
        }

        // Fonction pour savoir si l'arbre est vide
        public bool Empty()
        {
            return Size == 0;
        }

        // Fonction pour afficher l'arbre de façon ordonnée
        public override string ToString()
        {
            if (Empty())
                return " ";
            else
            {
                return ToString(Root);
            }
        }

        private string ToString(TreeNode<T> node)
        {
            if (node == null)
                return "";

            return $"{ToString(node.Left)} {node.Value} {ToString(node.Right)}";
        }

        // Fonction pour ajouter un élément à l'arbre
        public void Add(T value)
        {
            if (Root == null)
            {
                Root = new TreeNode<T>(value);
            }
            else
            {
                Add(Root, value);
            }
            Size++;
        }

        private void Add(TreeNode<T> node, T value)
        {
            if (Comparer<T>.Default.Compare(value,node.Value) < 0)
            {
                if (node.Left == null)
                {
                    node.Left = new TreeNode<T>(value);
                }
                else
                {
                    Add(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new TreeNode<T>(value);
                }
                else
                {
                    Add(node.Right, value);
                }
            }
        }

        // Fonction pour supprimer un élément de l'arbre
        public void Remove(T value)
        {
            Root = Remove(Root, value);
        }

        private TreeNode<T> Remove(TreeNode<T> node, T value)
        {
            if (node == null)
                return node;

            int comparison = Comparer<T>.Default.Compare(value, node.Value);
            if (comparison < 0)
            {
                node.Left = Remove(node.Left, value);
            }
            else if (comparison > 0)
            {
                node.Right = Remove(node.Right, value);
            }
            else
            {
                if (node.Left == null)
                {
                    return node.Right;
                }
                else if (node.Right == null)
                {
                    return node.Left;
                }

                node.Value = MinValue(node.Right);
                node.Right = Remove(node.Right, node.Value);
            }

            return node;
        }

        private T MinValue(TreeNode<T> node)
        {
            T minv = node.Value;
            while (node.Left != null)
            {
                minv = node.Left.Value;
                node = node.Left;
            }
            return minv;
        }
    }
}
