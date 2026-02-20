using System;

namespace uke1.Interfaces;

public interface IRepository<T>
{
    void Add(T item);
    void Remove(T item);
    T GetByIndex(int index);
    List<T> GetAll();
    T[] ToArray();
}
