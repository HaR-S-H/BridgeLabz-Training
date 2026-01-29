using System;
using System.IO;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        using var conn = new SqlConnection("your_connection_string");
        conn.Open();

        var cmd = new SqlCommand("SELECT Id, Name, Department, Salary FROM Employees", conn);
        var reader = cmd.ExecuteReader();

        using var writer = new StreamWriter("employees_report.csv");
        writer.WriteLine("Employee ID,Name,Department,Salary");

        while (reader.Read())
            writer.WriteLine($"{reader[0]},{reader[1]},{reader[2]},{reader[3]}");
    }
}
