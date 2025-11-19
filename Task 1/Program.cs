namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create two objects of Student
            Student s1 = new Student();
            Student s2 = new Student();

            // Assign different values
            s1.Name = "JK";
            s1.Age = 33;
            s1.Marks = 88.5;

            s2.Name = "BK";
            s2.Age = 22;

            // Display values
            Console.WriteLine("Student 1:");
            Console.WriteLine($"Name: {s1.Name}, Age: {s1.Age}, Marks: {s1.Marks}");

            Console.WriteLine("\nStudent 2:");
            Console.WriteLine($"Name: {s2.Name}, Age: {s2.Age}, Marks: {s2.Marks}");

            // Print static field
            Console.WriteLine($"\nSchool Name: {Student.schoolName}");
        }
    }
}