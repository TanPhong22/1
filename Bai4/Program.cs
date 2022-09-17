using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var ds = new List<KhuDat>();
            Console.WriteLine("1.Nha Pho");
            Console.WriteLine("2.Chung Cu");
            Console.WriteLine("3.Khu Dat");
            Console.Write("Nhap su lua chon: ");
            int chon = int.Parse(Console.ReadLine());
            if (chon == 1)
            {
                Console.Write("Nhap so luong nha pho cua cong ty: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                NhaPho kd = new NhaPho();
                    kd.Input();
                    ds.Add((NhaPho)kd);
                }
                Console.WriteLine("***********DANH SACH NHA PHO CUA CONG TY***********");
                foreach (NhaPho p in ds)
                {
                    p.Output();
                }
                var sumGiaBan = ds.Sum(p => (p as NhaPho).Giaban);
                Console.Write("Tong Gia Ban Nha Pho la: {0}", sumGiaBan);
                Console.WriteLine();
                Console.WriteLine("*************DANH SACH NHA PHO CO DIEN TICH >60 VA NAM XAY DUNG >=2020**************");
                var dsnp = ds.Where(p => (p as NhaPho).Dientich > 60 && (p as NhaPho).Namxaydung >= 2020).ToList();
                foreach(NhaPho p in dsnp)
                {
                    p.Output();
                }
                Console.WriteLine("***********TIM KIEM**********");
                Console.Write("Nhap dia diem can tim: ");
                string ddtk = Console.ReadLine();
                Console.Write("Nhap so tien hien tai co: ");
                long gbtk = long.Parse(Console.ReadLine());
                Console.Write("Nhap dien tich can tim kiem: ");
                float dttk = float.Parse(Console.ReadLine());
                Console.WriteLine("~~~~~~~~~~~~~KET QUA TIM KIEM~~~~~~~~~~~~~~");
                var dd = ds.Where(p => (p as NhaPho).Diadiem == ddtk && (p as NhaPho).Giaban <= gbtk && (p as NhaPho).Dientich >= dttk).ToList();
                if(dd.Count > 0)
                {
                    foreach (NhaPho p in dd)
                    {
                        p.Output();
                    }
                }
                else
                {
                    Console.WriteLine("/-*/-*/-*/-*/-*/-*/-*/KHONG CO-*/-*/-*/-*/-*/-*/");
                }
            }
            else if(chon == 2)
            {
                

                Console.Write("Nhap so luong chung cu cua cong ty: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    ChungCu kd = new ChungCu();
                    kd.Input();
                    ds.Add((ChungCu)kd);
                }
                Console.WriteLine("***********DANH SACH CHUNG CU CUA CONG TY***********");
                foreach (ChungCu p in ds)
                {
                    p.Output();
                }
                var sumGiaBan = ds.Sum(p => (p as ChungCu).Giaban);
                Console.Write("Tong Gia Ban Chung Cu la: {0}\n", sumGiaBan);
                Console.WriteLine("***********TIM KIEM**********");
                Console.Write("Nhap dia diem can tim: ");
                string ddtk = Console.ReadLine();
                Console.Write("Nhap so tien hien tai co: ");
                long gbtk = long.Parse(Console.ReadLine());
                Console.Write("Nhap dien tich can tim kiem: ");
                float dttk = float.Parse(Console.ReadLine());
                Console.WriteLine("~~~~~~~~~~~~~KET QUA TIM KIEM~~~~~~~~~~~~~~");
                var dd = ds.Where(p => (p as ChungCu).Diadiem == ddtk && (p as ChungCu).Giaban <= gbtk && (p as ChungCu).Dientich >= dttk).ToList();
                if(dd.Count > 0)
                {
                    foreach (ChungCu p in dd)
                    {
                        p.Output();
                    }
                }
                else
                {
                    Console.WriteLine("/-*/-*/-*/-*/-*/-*/-*/KHONG CO-*/-*/-*/-*/-*/-*/");

                }
            }
            else if(chon == 3)
            {
                Console.Write("Nhap so luong khu dat cua cong ty: ");
                int  n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    KhuDat kd = new KhuDat();
                    kd.Input();
                    ds.Add((KhuDat)kd);
                }
                Console.WriteLine("***********DANH SACH KHU DAT CUA CONG TY***********");
                foreach (KhuDat p in ds)
                {
                    p.Output();
                }
                var sumGiaBan = ds.Sum(p => (p as KhuDat).Giaban);
                Console.Write("Tong Gia Ban Khu Dat la: {0}\n", sumGiaBan);
                Console.WriteLine("***********DANH SACH CAC KHU DAT COS DIEN TICH > 100M2*************");
                var dskd = ds.Where(p => (p as KhuDat).Dientich > 100).ToList();
                foreach (KhuDat p in dskd)
                {
                    p.Output();
                }
            }
            Console.ReadKey();
        }
    }
}
