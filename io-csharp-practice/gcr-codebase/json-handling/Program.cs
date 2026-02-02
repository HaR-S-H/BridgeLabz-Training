using Newtonsoft.Json;
class Program
{
    static void Main()
    {
        var student = new
        {
            name = "harsh",
            age = 22,
            subjects = new[] { "math", "Science", "English" }
        };
        string json =  JsonConvert.SerializeObject(student, Formatting.Indented);
        Console.WriteLine(json);
    }
}