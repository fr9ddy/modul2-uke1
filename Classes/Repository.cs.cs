using System;
using uke1.Interfaces;

namespace uke1.Classes;

public class Repository<T> : IRepository<T>
{

    private List<T> items;
    public Repository()
    {
        items = new List<T>();
    }
    public List<T> GetAll()
    {
        return items;
    }
    public void Add(T item)
    {
        items.Add(item);
    }


    public T GetByIndex(int index)
    {
        if (index < 0 || index >= items.Count)
        {
            throw new IndexOutOfRangeException("Index out of bounds");
        }
        return items[index];
    }

    public void Remove(T item)
    {
        items.Remove(item);
    }

    public T[] ToArray()
    {
        return items.ToArray();
    }
}
