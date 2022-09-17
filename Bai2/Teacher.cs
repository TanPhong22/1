using Bai2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Teacher : Person
    {
        private string Diachi;

        public Teacher()
        {

        }
        public Teacher(string ID, string FullName, string diachi) : base(ID, FullName)
        {
            Diachi = diachi;
        }

        public string Diachi1
        {
            get
            {
                return Diachi;
            }

            set
            {
                Diachi = value;
            }
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap Dia Chi: ");
            Diachi = Console.ReadLine();
        }
        public override void Output()
        {
            base.Output();
            Console.Write("Dia Chi: {0}", Diachi);
        }
    }
}
