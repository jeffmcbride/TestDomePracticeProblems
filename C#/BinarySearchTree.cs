using System;

public class Node
{
    public int Value { get; set; }

    public Node Left { get; set; }

    public Node Right { get; set; }

    public Node(int value, Node left, Node right)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}

public class BinarySearchTree
{
    public static bool Contains(Node root, int value)
    {
        //Value is greater
        if (root.Value < value)
        {
            if (root.Right != null)
            {
                //Recurse down right side
                return Contains(root.Right, value);
            }
            
           
        }
           
        //Value is lesser   
        else if (root.Value > value)
        {
             if(root.Left != null)
             {
                 //Recurse down left side
                 return Contains(root.Left, value);
             }
        
        }
        
        //Found the number
        else
        {
            return true;
        }
        //Didn't find the number
        return false;         
    }

    public static void Main(string[] args)
    {
        Node n1 = new Node(1, null, null);
        Node n3 = new Node(3, null, null);
        Node n2 = new Node(2, n1, n3);

        Console.WriteLine(Contains(n2, 3));
    }
}