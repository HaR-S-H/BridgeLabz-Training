[AttributeUsage(AttributeTargets.Method)]
class ImportantMethodAttribute : Attribute
{
    public string Level { get; }
    public ImportantMethodAttribute(string level = "HIGH") => Level = level;
}

class Worker
{
    [ImportantMethod]
    public void CriticalTask() { }

    [ImportantMethod("LOW")]
    public void MinorTask() { }
}
