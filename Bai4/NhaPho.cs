using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class NhaPho:KhuDat
    {
        private int namxaydung;
        private int sotang;
        public NhaPho() 
        {
           
        }
        public NhaPho(string diadiem,long giaban,float dientich,int namxaydung, int sotang) :base(diadiem,giaban,dientich)
        {
            this.Namxaydung = namxaydung;
            this.Sotang = sotang;
        }

        public int Namxaydung { get => namxaydung; set => namxaydung = value; }
        public int Sotang { get => sotang; set => sotang = value; }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap nam xay dung: ");
            namxaydung = int.Parse(Console.ReadLine());
            Console.Write("Nhap so tang: ");
            sotang = int.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Nam xay dung: {0}",namxaydung);
            Console.WriteLine("So tang: {0}", sotang);
        }
    }
}
