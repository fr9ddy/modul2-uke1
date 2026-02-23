using System;
using uke1.Interfaces;

namespace uke1.Classes;

public class Repository<T> : IRepository<T>
{

    private List<T> _items;
    public Repository()
    {
        _items = new List<T>();
    }
    public List<T> GetAll()
    {
        return _items;
    }
    public void Add(T item)
    {
        _items.Add(item);
    }


    public T GetByIndex(int index)
    {
        if (index < 0 || index >= _items.Count)
        {
            throw new IndexOutOfRangeException("Index out of bounds");
        }
        return _items[index];
    }

    public void Remove(T item)
    {
        _items.Remove(item);
    }

    public T[] ToArray()
    {
        return _items.ToArray();
    }

    public bool IsEmpty()
    {
        return _items == null || _items.Count == 0;
    }
}