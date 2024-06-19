namespace Lab8;

public interface IManipulations<T>
{
    void Add(T item);
    void Delete(T item);
    T Change(T item);
}