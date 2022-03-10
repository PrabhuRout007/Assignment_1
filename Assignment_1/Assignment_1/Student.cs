using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Student : Subject
    {

        private string _student_name;
        private int _student_roll_no;
        private int[] _student_marks = new int[3];
        int total, rank;

        public string StudentName
        {
            get { return _student_name; }
            set { _student_name = value; }
        }
        public int StudentRollNo
        {
            get { return _student_roll_no; }
            set { _student_roll_no = value; }
        }
        public Student(int roll_no, string name )
        {
            this.StudentRollNo = roll_no;
            this._student_name = name;
        }

        public void Marks()
        {
            Console.WriteLine("Enter Marks of a Student in Physics Chemistry and Maths");
            for (int i = 0; i < _student_marks.Length; i++)
            {
                _student_marks[i] = Convert.ToInt32(Console.ReadLine());
                total += _student_marks[i];
            }
            
            
           // return total;
        }
        public int Rank()
        {
            int[] temp = new int[3];
            Array.Copy(_student_marks, temp, 3);
            Array.Sort(temp);
            Console.WriteLine(temp);

            return rank;
          
        }

        
        public void Display()
        {
            Console.WriteLine("Roll No :{0}\nName: {1}\nTotal_Marks: {2}",StudentRollNo,StudentName,total);
        }
        
        
    }
}
