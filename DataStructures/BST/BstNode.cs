namespace DataStructures.BST;

public class BstNode<T> where T : IComparable
{
    public T Data { get; }
    public BstNode<T>? Parent { get; }
    public BstNode<T>? Left { get; set; }
    public BstNode<T>? Right { get; set; }

    public BstNode(T data)
    {
        Data = data;
    }

    public BstNode(BstNode<T> parent, T data)
    {
        Parent = parent;
        Data = data;
    }
    public void Insert(T data)
    {
        if (Data.CompareTo(data) > 0)
            InsertLeft(data);
        else
            InsertRight(data);
    }

    private void InsertRight(T data)
    { 
        if (Right != null)
            Right.Insert(data);
        else
            Right = new BstNode<T>(this, data);
    }

    private void InsertLeft(T data)
    { 
        if (Left != null)
            Left.Insert(data);
        else
            Left = new BstNode<T>(this, data);
    }

    public bool Contains(T data)
    {
        return Data.CompareTo(data) switch
        {
            0 => true,
            > 0 => Left != null && Left.Contains(data),
            _ => Right != null && Right.Contains(data),
        }; 
    }

    public T GetMin()
    {
        return Left != null ? Left.GetMin() : Data;
    }
    public T GetMax()
    {
        return Right != null ? Right.GetMax() : Data;
    }
}
