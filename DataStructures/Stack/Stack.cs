namespace DataStructures.Stack;

public class Stack<T>
{
    private int _size;
    private readonly T[] _data;

    public Stack(int capacity)
    {
        _data = new T[capacity];
        _size = 0;
    }

    public void Push(T data)
    {
        if (_size == _data.Length)
            throw new Exception("Stack is over populated");
        _data[_size++] = data;
    }

    public void Reverse()
    {
        for (var i = 0; i < _size/2; i++)
        {
            (_data[i], _data[_size - i - 1]) = (_data[_size - i - 1], _data[i]);
        }
    }

    public T Pop()
    {
        if (_size == 0)
            throw new Exception("Stack is under populated");
        var item = _data[--_size];
        return item;
    }

    public void Print()
    {
        for (var i = 0; i < _size; i++)
        {
            Console.WriteLine(_data[i]); 
        }
    }
}