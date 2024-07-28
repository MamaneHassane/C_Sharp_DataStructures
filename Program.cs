// See https://aka.ms/new-console-template for more information
using C_Sharp_DataStructures;
using System;

Console.WriteLine("Hello, World!");

Node<string> node = new("Hassane");

Console.WriteLine(node);

_Queue<int> queue = new _Queue<int>();

Console.WriteLine(queue);
queue.Push(1);
queue.Push(2);
queue.Push(3);
queue.Push(-4);
Console.WriteLine(queue);
queue.Pop();
queue.Pop();
Console.WriteLine(queue);
queue.Pop();
Console.WriteLine(queue);
queue.Pop();
Console.WriteLine(queue);