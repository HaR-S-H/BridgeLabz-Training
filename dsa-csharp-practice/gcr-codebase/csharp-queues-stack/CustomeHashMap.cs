using System.Collections.Generic;

class MyHashMap
{
    private const int SIZE = 10;
    private List<KeyValuePair<int, int>>[] table = new List<KeyValuePair<int, int>>[SIZE];

    private int Hash(int key) => key % SIZE;

    public void Put(int key, int value)
    {
        int index = Hash(key);

        if (table[index] == null)
            table[index] = new List<KeyValuePair<int, int>>();

        foreach (var pair in table[index])
        {
            if (pair.Key == key)
            {
                table[index].Remove(pair);
                break;
            }
        }

        table[index].Add(new KeyValuePair<int, int>(key, value));
    }

    public int Get(int key)
    {
        int index = Hash(key);
        if (table[index] != null)
        {
            foreach (var pair in table[index])
                if (pair.Key == key)
                    return pair.Value;
        }
        return -1;
    }

    public void Remove(int key)
    {
        int index = Hash(key);
        if (table[index] != null)
        {
            table[index].RemoveAll(p => p.Key == key);
        }
    }
}
