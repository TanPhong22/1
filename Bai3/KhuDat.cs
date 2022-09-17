using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class KhuDat
    {
        private string diadiem;
        private long giaban;
        private float dientich;
        public KhuDat()
        {
            
        }
        public KhuDat(string diadiem, long giaban, float dientich)
        {
            this.diadiem = diadiem;
            this.giaban = giaban;
            this.dientich = dientich;
        }

        public string Diadiem { get => diadiem; set => diadiem = value; }
        public long Giaban { get => giaban; set => giaban = value; }
        public float Dientich { get => dientich; set => dientich = value; }
        
        public void Input()
        {
            Console.Write("Nhap dia diem: ");
            diadiem = Console.ReadLine();
            Console.Write("Nhap gia ban: ");
            giaban = long.Parse(Console.ReadLine());
            Console.Write("Nhap dien tich: ");
            dientich = float.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("Dia diem: {0}", diadiem);
            Console.WriteLine("Gia Ban: {0}VND", giaban);
            Console.WriteLine("Dien Tich: {0} m2", dientich);
        }
    }
}
