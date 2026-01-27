using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute
{
    public string Name;
    public AuthorAttribute(string name) => Name = name;
}

[Author("Harsh Gupta")]
class MyClass { }

class Program
{
    static void Main()
    {
        var attr = (AuthorAttribute)Attribute.GetCustomAttribute(typeof(MyClass), typeof(AuthorAttribute));
        Console.WriteLine("Author: " + attr.Name);
    }
}
