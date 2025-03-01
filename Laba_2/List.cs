using System.Collections;

namespace Laba_2;

public class List<T> : IEnumerable<T>
{
    private T[] elements;
    private int count;

    public List()
    {
        elements = [];
        count = 0;
    }

    public List(IEnumerable<T> elements)
    {
        this.elements = elements.ToArray();
        count = this.elements.Length;
    }

    public void Add(T item)
    {
        Array.Resize(ref elements, count + 1);
        elements[count] = item;
        count++;
    }

    public override string ToString()
    {
        return $"List({string.Join(", ", elements.Select(e => e.ToString()))})";
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public static List<T> operator +(T item, List<T> list)
    {
        var newList = new List<T>(list.elements);
        newList.InsertAt(0, item);
        return newList;
    }

    public static List<T> operator --(List<T> list)
    {
        var newList = new List<T>(list.elements);
        if (newList.count > 0)
        {
            newList.RemoveAt(0);
        }

        return newList;
    }

    public static bool operator !=(List<T> list1, List<T> list2)
    {
        return !list1.Equals(list2);
    }

    public static bool operator ==(List<T> list1, List<T> list2)
    {
        return list1.Equals(list2);
    }

    public static List<T> operator *(List<T> list1, List<T> list2)
    {
        var newList = new List<T>(list1.elements);
        newList.AddRange(list2.elements);
        return newList;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || obj.GetType() != this.GetType())
            return false;

        var other = (List<T>)obj;
        return elements.SequenceEqual(other.elements);
    }

    private void InsertAt(int index, T item)
    {
        Array.Resize(ref elements, count + 1);
        for (int i = count; i > index; i--)
        {
            elements[i] = elements[i - 1];
        }

        elements[index] = item;
        count++;
    }

    private void RemoveAt(int index)
    {
        for (int i = index; i < count - 1; i++)
        {
            elements[i] = elements[i + 1];
        }

        Array.Resize(ref elements, count - 1);
        count--;
    }

    private void AddRange(T[] items)
    {
        int newCount = count + items.Length;
        Array.Resize(ref elements, newCount);
        Array.Copy(items, 0, elements, count, items.Length);
        count = newCount;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < count; i++)
        {
            yield return elements[i];
        }
    }
    
    public int CountWordsWithCapitalLetter()
    {
        if (typeof(T) == typeof(string))
        {
            return this.Cast<string>().Count(word => !string.IsNullOrEmpty(word) && char.IsUpper(word[0]));
        }

        throw new InvalidOperationException("Метод применяется только к списку строк.");
    }

    public bool HasDuplicates()
    {
        var set = new HashSet<T>();
        foreach (var item in this)
        {
            if (!set.Add(item))
                return true;
        }
        return false;
    }
}