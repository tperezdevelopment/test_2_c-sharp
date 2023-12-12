using System.Data;

public class ClassGeneric<T> where T : struct
{
    List<T> list;

    public ClassGeneric()
    {
        list = new List<T>();
    }
    public void Add(T item)
    {
        list.Add(item);
    }

    public T getElement(int index)
    {
        try
        {
            return list[index];
        }
        catch
        {
            throw new IndexOutOfRangeException($"Index {index} out of range");
        }
    }

    public List<T> OrderCollection()
    {
        return list.OrderByDescending(item => item).ToList();
    }
}
