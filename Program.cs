// See https://aka.ms/new-console-template for more information
using C_Sharp_DataStructures;

Console.WriteLine("Hello, World!");

Node<string> node = new("Hassane");

Console.WriteLine(node);

_Stack<int> stack = new _Stack<int>();
Console.WriteLine(stack);
stack.Push(1);
stack.Push(2);  
stack.Push(3);
Console.WriteLine(stack);
stack.Pop();
stack.Push(-4);
Console.WriteLine(stack);
stack.Pop();
stack.Pop();
stack.Pop();
stack.Pop();
Console.WriteLine(stack);