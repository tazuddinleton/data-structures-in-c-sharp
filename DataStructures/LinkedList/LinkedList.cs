
namespace DataStructures.LinkedList;

public class LinkedList<T>
{
    private LinkedListNode<T>? _head; 
    // Crate a linked list of 1->2->3->4->5->null
    public void AddLast(T data)
    {
        var newNode = new LinkedListNode<T>(data);
        if (this._head == null)
            this._head = newNode;
        else
        { 
            var h = this._head;
            while (h.Next != null)
            {
                h = h.Next;
            } 
            h.Next = newNode; 
        }
    }

    public static LinkedList<T> Of(params T[] data)
    {
        var list = new LinkedList<T>();
        foreach (var d in data)
        {
            list.AddLast(d);
        } 
        return list;
    }

    public void Print()
    {
        var h = this._head;
        while (h != null)
        {
            Console.WriteLine(h.Data);
            h = h.Next;
        }
    }

    public void Reverse()
    {
        // 1->2->3->4->5
        var curr = this._head;
        LinkedListNode<T> prev = null;
        while (curr != null)
        {
            var temp = curr.Next; 
            curr.Next = prev; 
            prev = curr;
            curr = temp;
        } 
        this._head = prev;
    }
}