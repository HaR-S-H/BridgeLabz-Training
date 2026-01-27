using System;
using System.Reflection;
using System.Text;

class Program
{
    static string ToJson(object obj)
    {
        var sb = new StringBuilder("{ ");
        var fields = obj.GetType().GetFields();

        foreach (var f in fields)
        {
            sb.Append($"\"{f.Name}\": \"{f.GetValue(obj)}\", ");
        }

        return sb.ToString().TrimEnd(',', ' ') + " }";
    }
}
