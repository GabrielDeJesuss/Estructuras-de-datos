using System;

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

// Clase que contiene el algoritmo de eliminacion
public class BSTDeletion
{
    // Eliminar un nodo del arbol binario de busqueda
    public Node DeleteNode(Node root, int key)
    {
        if (root == null)
        {
            return root;
        }

        // Buscar el nodo que se desea eliminar
        if (key < root.Data)
        {
            root.Left = DeleteNode(root.Left, key);
        }
        else if (key > root.Data)
        {
            root.Right = DeleteNode(root.Right, key);
        }
        else
        {
            // Caso 1: Nodo sin hijo izquierdo
            if (root.Left == null)
            {
                return root.Right;
            }

            // Caso 2: Nodo sin hijo derecho
            else if (root.Right == null)
            {
                return root.Left;
            }

            // Caso 3: Nodo con dos hijos
            // Buscar el sucesor inorden (menor valor del subarbol derecho)
            root.Data = MinValue(root.Right);

            // Eliminar el sucesor de su posicion original
            root.Right = DeleteNode(root.Right, root.Data);
        }

        return root;
    }

    // Obtener el menor valor de un subarbol
    private int MinValue(Node root)
    {
        int minv = root.Data;

        while (root.Left != null)
        {
            minv = root.Left.Data;
            root = root.Left;
        }

        return minv;
    }
}

// Programa principal para probar la eliminacion
public class Program
{
    // Mostrar los valores del arbol en orden ascendente
    public static void PrintInOrder(Node root)
    {
        if (root == null)
        {
            return;
        }

        PrintInOrder(root.Left);
        Console.Write(root.Data + " ");
        PrintInOrder(root.Right);
    }

    public static void Main(string[] args)
    {
        // Crear el arbol binario de busqueda
        Node root = new Node(50);

        root.Left = new Node(30);
        root.Right = new Node(70);

        root.Left.Left = new Node(20);
        root.Left.Right = new Node(40);

        root.Right.Left = new Node(60);
        root.Right.Right = new Node(80);

        // Crear el objeto de eliminacion
        BSTDeletion deletion = new BSTDeletion();

        Console.WriteLine("Arbol original:");
        PrintInOrder(root);

        // Eliminar un nodo sin hijos
        root = deletion.DeleteNode(root, 20);

        Console.WriteLine("\n\nDespues de eliminar 20:");
        PrintInOrder(root);

        // Eliminar un nodo con un hijo
        root = deletion.DeleteNode(root, 30);

        Console.WriteLine("\n\nDespues de eliminar 30:");
        PrintInOrder(root);

        // Eliminar un nodo con dos hijos
        root = deletion.DeleteNode(root, 70);

        Console.WriteLine("\n\nDespues de eliminar 70:");
        PrintInOrder(root);

        Console.WriteLine();
        Console.ReadKey();
    }
}
