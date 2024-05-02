namespace DataStructures.LinkedList;

public class LinkedListNode<T>
{ 
    public LinkedListNode(T data)
    {
        this.Data = data; 
    }
    public T Data { get; set; }
    public LinkedListNode<T>? Next { get; set; }
}