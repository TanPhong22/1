using Bai2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Student : Person
    {
        private float Ave;
        private string Faculty;
        public Student()
        {

        }
        public Student(string ID, string FullName, float ave, string faculty) : base(ID, FullName)
        {
            Ave = ave;
            Faculty = faculty;
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
                return Faculty;
            }

            set
            {
                Faculty = value;
            }
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap Diem Trung : ");
            Ave = float.Parse(Console.ReadLine());
            Console.Write("Nhap Khoa: ");
            Faculty = Console.ReadLine();
        }
        public override void Output()
        {
            base.Output();
            Console.Write("Diem Trung Binh: {0}", Ave);
            Console.Write("Khoa: {0}", Faculty);
        }
    }
}
