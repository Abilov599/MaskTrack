using System.Collections;

namespace Workaround;

public class MyList<T> : IEnumerable<T>
{
    private T[] _items;
    private int _count;

    public MyList(params T[] initialElements)
    {
        _items = new T[initialElements.Length];
        _count = 0;
        foreach (T element in initialElements)
        {
            Add(element);
        }
    }

    public void Add(T item)
    {
        if (_count == _items.Length) Array.Resize(ref _items, _count + 1);
        _items[_count++] = item;
    }

    public T Get(int index)
    {
        if (index < 0 || index >= _count) throw new IndexOutOfRangeException("Index is out of range.");
        return _items[index];
    }

    public int Count { get => _count; }
    
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < _count; i++) yield return _items[i];
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}