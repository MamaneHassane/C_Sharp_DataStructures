// See https://aka.ms/new-console-template for more information
using C_Sharp_DataStructures.Binary_Search_Tree;
using C_Sharp_DataStructures.Classics;
using System;

Console.WriteLine("Hello, World!");

Node<string> node = new("HassaneMamane");

Console.WriteLine(node);

_BinarySearchTree<int> tree = new();

tree.Add(1);
tree.Add(2);    
tree.Add(3);
tree.Add(-4);
Console.WriteLine(tree);
Console.WriteLine($"Taille de la treee {tree.Count()} ");
tree.Remove(3);
Console.WriteLine(tree);
tree.Remove(1);
Console.WriteLine(tree);
tree.Remove(-4);
Console.WriteLine(tree);
tree.Add(8);
tree.Add(-5);
Console.WriteLine(tree);
tree.Remove(2);
Console.WriteLine(tree);
tree.Add(4);
tree.Add(-1);
Console.WriteLine(tree);
