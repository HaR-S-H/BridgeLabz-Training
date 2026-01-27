using System;
using System.Collections.Generic;
using System.Reflection;

class Mapper
{
    public static T ToObject<T>(Dictionary<string, object> data) where T : new()
    {
        T obj = new T();
        Type type = typeof(T);

        foreach (var prop in data)
        {
            FieldInfo field = type.GetField(prop.Key);
            if (field != null)
                field.SetValue(obj, prop.Value);
        }
        return obj;
    }
}

class User
{
    public string Name;
    public int Age;
}
