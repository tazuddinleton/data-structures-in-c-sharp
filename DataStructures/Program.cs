using DataStructures.BST;
using DataStructures.SortingAlgorithms;

namespace DataStructures;

public static class Program {
    public static void Main(string[] args)
    {
        // DemoLinkedListReversal();
        // DemoStackPushPop();
        // DemoStackReversal();
        // DemoBST();
        var sorted = MergeSorter.Sort(new int[]{5,4,3,6,7});
        
    }

    public static void DemoBST()
    {
        var bst = new BinarySearchTree<int>();
        bst.Insert(20);
        bst.Insert(30);
        bst.Insert(10);
        bst.Insert(8);
        bst.Insert(32);
        bst.Insert(592);
        bst.Insert(60);

        Console.WriteLine("Contains 32?");
        Console.WriteLine(bst.Contains(32));
        Console.WriteLine("Contains 9?");
        Console.WriteLine(bst.Contains(9));
        
        Console.WriteLine("Min: ");
        Console.WriteLine(bst.GetMin());
        
        Console.WriteLine("Max: ");
        Console.WriteLine(bst.GetMax());
    }

    public static void DemoStackReversal()
    {
        var stack = new Stack.Stack<int>(10);
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Print();
        stack.Reverse();
        Console.WriteLine("After reversing the stack");
        stack.Print();
    }
    public static void DemoStackPushPop()
    {
        var stack = new Stack.Stack<int>(10);
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Print();
        stack.Pop();
        Console.WriteLine("After popping out last item");
        stack.Print();
    }
    public static void DemoLinkedListReversal()
    { 
        var list = LinkedList.LinkedList<string>.Of("A", "B", "C", "D");
        list.AddLast("E"); 
        list.Print();
        
        list.Reverse();
        Console.WriteLine("After reverse: ");
        list.Print();
    }
}