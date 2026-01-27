using System;
using System.Linq;
using System.Reflection;

[AttributeUsage(AttributeTargets.Property)]
class InjectAttribute : Attribute { }

class Service { public void Serve() => Console.WriteLine("Service Called"); }

class Client
{
    [Inject]
    public Service MyService { get; set; }
}

class Container
{
    public static T Resolve<T>() where T : new()
    {
        T obj = new T();
        foreach (var prop in typeof(T).GetProperties())
        {
            if (Attribute.IsDefined(prop, typeof(InjectAttribute)))
            {
                var service = Activator.CreateInstance(prop.PropertyType);
                prop.SetValue(obj, service);
            }
        }
        return obj;
    }
}
