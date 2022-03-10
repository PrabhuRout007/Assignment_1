using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the name of the Student:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the RollNo of the Student:");
            int rollno = Convert.ToInt32(Console.ReadLine());
            Student a1 = new Student(rollno,name);
            a1.Marks();
            a1.Display();


            Console.WriteLine("Enter the name of the Student:");
            string name2 = Console.ReadLine();
            Console.WriteLine("Enter the RollNo of the Student:");
            int rollno2 = Convert.ToInt32(Console.ReadLine());
            Student a2 = new Student(rollno2, name2);
            a2.Marks();
            a2.Display();

        }
    }
}
