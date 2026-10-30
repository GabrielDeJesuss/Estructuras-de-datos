using System;
using System.Collections.Generic;

// Clase que representa cada nodo del arbol
public class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int value)
    {
        Data = value;
        Left = null;
        Right = null;
    }
}

// Clase que contiene los recorridos del arbol
public class TreeTraversals
{
    // 1. Recorrido Preorden (Root, Left, Right)
    public void PreOrder(Node node)
    {
        if (node == null)
        {
            return;
        }

        Console.Write(node.Data + " ");

        PreOrder(node.Left);
        PreOrder(node.Right);
    }

    // 2. Recorrido Inorden (Left, Root, Right)
    public void InOrder(Node node)
    {
        if (node == null)
        {
            return;
        }

        InOrder(node.Left);

        Console.Write(node.Data + " ");

        InOrder(node.Right);
    }

    // 3. Recorrido Posorden (Left, Right, Root)
    public void PostOrder(Node node)
    {
        if (node == null)
        {
            return;
        }

        PostOrder(node.Left);
        PostOrder(node.Right);

        Console.Write(node.Data + " ");
    }

    // 4. Recorrido Por Niveles (BFS)
    public void LevelOrder(Node root)
    {
        if (root == null)
        {
            return;
        }

        Queue<Node> queue = new Queue<Node>();

        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();

            Console.Write(current.Data + " ");

            if (current.Left != null)
            {
                queue.Enqueue(current.Left);
            }

            if (current.Right != null)
            {
                queue.Enqueue(current.Right);
            }
        }
    }
}

// Programa principal para probar los recorridos
public class Program
{
    public static void Main(string[] args)
    {
        // Crear los nodos del arbol
        Node root = new Node(50);

        root.Left = new Node(30);
        root.Right = new Node(70);

        root.Left.Left = new Node(20);
        root.Left.Right = new Node(40);

        root.Right.Left = new Node(60);
        root.Right.Right = new Node(80);

        // Crear objeto de recorridos
        TreeTraversals traversals = new TreeTraversals();

        // Ejecutar los cuatro recorridos
        Console.WriteLine("Recorrido Preorden:");
        traversals.PreOrder(root);

        Console.WriteLine("\n\nRecorrido Inorden:");
        traversals.InOrder(root);

        Console.WriteLine("\n\nRecorrido Posorden:");
        traversals.PostOrder(root);

        Console.WriteLine("\n\nRecorrido Por Niveles (BFS):");
        traversals.LevelOrder(root);

        Console.WriteLine();

        Console.ReadKey();
    }
}
