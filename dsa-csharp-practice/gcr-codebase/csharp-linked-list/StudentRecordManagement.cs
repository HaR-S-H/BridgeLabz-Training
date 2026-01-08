using System;
class StudentNode
{
    public int RollNo;
    public string Name;
    public int Age;
    public char Grade;
    public StudentNode Next;

    public StudentNode(int rollNo, string name, int age, char grade)
    {
        RollNo = rollNo;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }
}

class StudentLinkedList
{
    private StudentNode head;

    // Add at Beginning
    public void AddAtBeginning(int rollNo, string name, int age, char grade)
    {
        StudentNode newNode = new StudentNode(rollNo, name, age, grade);
        newNode.Next = head;
        head = newNode;
        Console.WriteLine("Student added at beginning.");
    }

    // Add at End
    public void AddAtEnd(int rollNo, string name, int age, char grade)
    {
        StudentNode newNode = new StudentNode(rollNo, name, age, grade);

        if (head == null)
        {
            head = newNode;
            return;
        }

        StudentNode temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }

        temp.Next = newNode;
        Console.WriteLine("Student added at end.");
    }

    // Add at Specific Position (1-based index)
    public void AddAtPosition(int position, int rollNo, string name, int age, char grade)
    {
        if (position <= 0)
        {
            Console.WriteLine("Invalid position!");
            return;
        }

        if (position == 1)
        {
            AddAtBeginning(rollNo, name, age, grade);
            return;
        }

        StudentNode newNode = new StudentNode(rollNo, name, age, grade);
        StudentNode temp = head;

        for (int i = 1; i < position - 1 && temp != null; i++)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Position out of range.");
            return;
        }

        newNode.Next = temp.Next;
        temp.Next = newNode;
        Console.WriteLine("Student added at position " + position);
    }

    // Delete by Roll Number
    public void DeleteByRollNo(int rollNo)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        if (head.RollNo == rollNo)
        {
            head = head.Next;
            Console.WriteLine("Student record deleted.");
            return;
        }

        StudentNode temp = head;
        while (temp.Next != null && temp.Next.RollNo != rollNo)
        {
            temp = temp.Next;
        }

        if (temp.Next == null)
        {
            Console.WriteLine("Student not found.");
        }
        else
        {
            temp.Next = temp.Next.Next;
            Console.WriteLine("Student record deleted.");
        }
    }

    // Search by Roll Number
    public void SearchByRollNo(int rollNo)
    {
        StudentNode temp = head;

        while (temp != null)
        {
            if (temp.RollNo == rollNo)
            {
                Console.WriteLine("Student Found:");
                Console.WriteLine($"Roll No: {temp.RollNo}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Student not found.");
    }

    // Update Grade by Roll Number
    public void UpdateGrade(int rollNo, char newGrade)
    {
        StudentNode temp = head;

        while (temp != null)
        {
            if (temp.RollNo == rollNo)
            {
                temp.Grade = newGrade;
                Console.WriteLine("Grade updated successfully.");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Student not found.");
    }

    // Display All Records
    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("No student records found.");
            return;
        }

        StudentNode temp = head;
        Console.WriteLine("\nStudent Records:");
        while (temp != null)
        {
            Console.WriteLine($"Roll No: {temp.RollNo}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
            temp = temp.Next;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        StudentLinkedList list = new StudentLinkedList();
        int choice;

        do
        {
            Console.WriteLine("\n==== Student Record Management ====");
            Console.WriteLine("1. Add at Beginning");
            Console.WriteLine("2. Add at End");
            Console.WriteLine("3. Add at Position");
            Console.WriteLine("4. Delete by Roll Number");
            Console.WriteLine("5. Search by Roll Number");
            Console.WriteLine("6. Update Grade");
            Console.WriteLine("7. Display All Records");
            Console.WriteLine("8. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            int rollNo, age, position;
            string name;
            char grade;

            switch (choice)
            {
                case 1:
                    Console.Write("Roll No: ");
                    rollNo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Age: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Grade: ");
                    grade = Convert.ToChar(Console.ReadLine());
                    list.AddAtBeginning(rollNo, name, age, grade);
                    break;

                case 2:
                    Console.Write("Roll No: ");
                    rollNo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Age: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Grade: ");
                    grade = Convert.ToChar(Console.ReadLine());
                    list.AddAtEnd(rollNo, name, age, grade);
                    break;

                case 3:
                    Console.Write("Position: ");
                    position = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Roll No: ");
                    rollNo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Age: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Grade: ");
                    grade = Convert.ToChar(Console.ReadLine());
                    list.AddAtPosition(position, rollNo, name, age, grade);
                    break;

                case 4:
                    Console.Write("Enter Roll Number to Delete: ");
                    rollNo = Convert.ToInt32(Console.ReadLine());
                    list.DeleteByRollNo(rollNo);
                    break;

                case 5:
                    Console.Write("Enter Roll Number to Search: ");
                    rollNo = Convert.ToInt32(Console.ReadLine());
                    list.SearchByRollNo(rollNo);
                    break;

                case 6:
                    Console.Write("Enter Roll Number: ");
                    rollNo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter New Grade: ");
                    grade = Convert.ToChar(Console.ReadLine());
                    list.UpdateGrade(rollNo, grade);
                    break;

                case 7:
                    list.Display();
                    break;

                case 8:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 8);
    }
}

