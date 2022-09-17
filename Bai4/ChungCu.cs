using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class ChungCu :KhuDat
    {
        private int tang;
        public ChungCu()
        {
           
        }
        public ChungCu(string diadiem, long giaban, float dientich, int tang):base(diadiem,giaban,dientich)
        {
            this.tang = tang;
        }

        public int Tang { get => tang; set => tang = value; }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap tang: ");
            tang =int.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Thuoc tang: {0}", tang);
        }
    }
}
