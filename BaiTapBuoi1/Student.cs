using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Student
    {
        private string StudentID;
        private string StudentName;
        private float Ave;
        private string Faculty;

        public Student(string studentID, string studentName, float ave, string faculty)
        {
            StudentID = studentID;
            StudentName = studentName;
            Ave = ave;
            Faculty = faculty;
        }
        public Student()
        {

        }
        public string StudentID1
        {
            get
            {
                return StudentID;
            }

            set
            {
                StudentID = value;
            }
        }

        public string StudentName1
        {
            get
            {
                return StudentName;
            }

            set
            {
                StudentName = value;
            }
        }

        public float Ave1
        {
            get
            {
                return Ave;
            }

            set
            {
                Ave = value;
            }
        }

        public string Faculty1
        {
            get
            {
                return Faculty.ToUpper();
            }

            set
            {
                Faculty = value;
            }
        }
        public void Input()
        {
            Console.Write("Nhap MSSV: ");
            StudentID = Console.ReadLine();
            Console.Write("Nhap Ho va Ten: ");
            StudentName = Console.ReadLine();
            Console.Write("Nhap Diem Trung Binh: ");
            Ave = float.Parse(Console.ReadLine());
            Console.Write("Nhap Khoa: ");
            Faculty = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine("MSSV : {0} ", StudentID);
            Console.WriteLine("Ho va Ten : {0} ", StudentName);
            Console.WriteLine("Diem Trung Binh : {0} ", Ave);
            Console.WriteLine("Khoa : {0} ", Faculty);
        }

    }
}

