using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] smarks = new int[3];
            Student[] s = new Student[4];
            int total_marks =0;

            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("Enter Student Name");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter Student Roll No");
                int RollNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Marks if Physics, chemistry maths");
                for (int j = 0; j < 3; j++)
                {
                    smarks[i] = Convert.ToInt32(Console.ReadLine());
                    total_marks += smarks[i];
                }
                s[i] = new Student(Name, RollNo, total_marks);
            }
            Array.Sort(s);

            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }

             

        }
    }
}
