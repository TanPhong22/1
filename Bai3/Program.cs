using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ds = new List<KhuDat>();
            
            Console.Write("Nhap so luong khu dat cua cong ty: ");
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++){
                Console.WriteLine("Khu dat thu {0}", i + 1);
                var kd = new KhuDat();
                kd.Input();
                ds.Add(kd);
            }
            Console.WriteLine();
            Console.WriteLine("*********DANH SACH CAC KHU DAT CUA CONG TY**********");

            foreach (KhuDat khudat in ds)
            {
                khudat.Output();
            }
            Console.WriteLine();
            Console.WriteLine("*********DANH SACH CAC KHU DAT CO DIEN TICH TANG DAN**********");
            var sotfDT = ds.OrderBy(p => p.Dientich).ToList();
            foreach( KhuDat khudat in sotfDT)
            {
                khudat.Output();
            }
            Console.WriteLine();
            Console.WriteLine("**********DANH SACH KHU DAT CO GIA BAN DUOI 1TY VA CO DIEN TICH >=60m2**************");
            List<KhuDat> listkhudatduoi1tyvadientichlonhonhoacbang60m2 = ds.Where(p => p.Giaban < 1000000000 && p.Dientich >= 60).ToList();
            if(listkhudatduoi1tyvadientichlonhonhoacbang60m2.Count == 0)
            {
                Console.WriteLine("khong co khu dat nao nhu the het !!!!");
            }
            else
            {
                foreach(KhuDat khudat in listkhudatduoi1tyvadientichlonhonhoacbang60m2)
                {
                    khudat.Output();
                }
            }
            Console.WriteLine();
            var AveKhuDat = ds.Where(p => p.Dientich > 1000).Average(p => p.Giaban);
            Console.Write("Dien Tich Trung Binh = {0}VND", AveKhuDat);

        }
    }
}

