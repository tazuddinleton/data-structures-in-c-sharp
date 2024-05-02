namespace DataStructures.BST;

public class BinarySearchTree<T> where T : IComparable
{
    private BstNode<T> _root;
    public void Insert(T data)
    {
        if (_root == null)
            _root = new BstNode<T>(data); 
        else 
            _root.Insert(data); 
    }

    public bool Contains(T data)
    {
        return _root.Contains(data);
    }

    public T GetMin()
    {
        return _root.GetMin();
    }

    public T GetMax()
    {
        return _root.GetMax();
    }
    
}