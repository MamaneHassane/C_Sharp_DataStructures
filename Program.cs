// See https://aka.ms/new-console-template for more information
using C_Sharp_DataStructures;
using System;

Console.WriteLine("Hello, World!");

Node<string> node = new("HassaneMamane");

Console.WriteLine(node);

_LinkedList<int> list = new();

list.Add(1);
list.Add(2);    
list.Add(3);
list.Add(-4);
Console.WriteLine(list);
Console.WriteLine($"Taille de la liste {list.Count()} ");
list.RemoveValue(3);
Console.WriteLine(list);
list.RemoveValue(1);
Console.WriteLine(list);
list.RemoveValue(-4);
Console.WriteLine(list);
list.Add(8);
list.Add(-5);
Console.WriteLine(list);
list.Remove(2);
Console.WriteLine(list);
list.Add(4);
list.Add(-1);
Console.WriteLine(list);
Console.WriteLine($"Index de -1 : {list.GetIndexOf(-1)} ");
Console.WriteLine($"Valeur à l'index 4 : {list.Get(4)}");