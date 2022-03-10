using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Assignment
{
    class Student : IComparable<Student>
    {
        string name;
        int rollno;
        int TotalMarks;

        public Student(string snmae, int srollno, int stotal)
        {
            this.name = snmae;
            this.rollno = srollno;
            this.TotalMarks = stotal;
        }

        public int CompareTo(Student Student)
        {
            return Student.TotalMarks - this.TotalMarks;
        }
        public override String ToString()
        {
            return this.name + " " + this.rollno + " " + this.TotalMarks;
        }
    }
}

