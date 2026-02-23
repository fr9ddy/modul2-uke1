using System;

namespace uke1.Interfaces;

public interface IRepository<T>
{
    void Add(T item);
    void Remove(T item);
    List<T> GetAll();
    T[] ToArray();
    T GetByIndex(int index);
    bool IsEmpty();
}
