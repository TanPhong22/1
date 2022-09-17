using Bai2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            var ds = new List<Person>();
            int chon;
            Console.Write("Nhap 1 de chon sinh vien ---------------- Nhap 2 de cho giao vien : ");
            chon = int.Parse(Console.ReadLine());
            if (chon == 1)
            {
                Student sv = new Student();
                Console.Write("Nhap so luong sinh vien: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {

                    sv.Input();
                    ds.Add(sv);
                }
                foreach (Student s in ds)
                {
                    s.Output();
                }
                Console.WriteLine();
                Console.WriteLine("****************DANH SACH SINH VIEN KHOA CNTT**********************");
                var dssv = new List<Person>();
                dssv = ds.Where(p => (p as Student).Faculty1 == "CNTT").ToList();
                if(dssv.Count == 0)
                {
                    Console.WriteLine("~~~~~~~khong co sinh vien~~~~~~~~");

                }
                else
                {
                    foreach (Student s in dssv)
                    {
                        s.Output();
                    }
                }
                Console.WriteLine();
                Console.WriteLine("***************DANH SACH SINH VIEN CO DIEM TRUNG BINH NHO HON 5 VA THUOC KHOA CNTT*****************");
                List<Person> dssvnh5 = ds.Where(p => (p as Student).Faculty1 == "CNTT" && (p as Student).Ave1 < 5).ToList();
                if (dssvnh5.Count == 0)
                {
                    Console.WriteLine("~~~~~~~khong co sinh vien~~~~~~~~");

                }
                else
                {
                    foreach (Student s in dssvnh5)
                    {
                        s.Output();
                    }
                }
                Console.WriteLine();
                Console.WriteLine("**************DANH SACH SINH VIEN CO DIEM TRUNG BINH CAO NHAT****************");
                List<Person> listStudentCNTT = ds.Where(p => (p as Student).ID1 == "CNTT").ToList();
                var maxave = ds.Max(p => (p as Student).Ave1);
                var listStudentMax = listStudentCNTT.Where(p => (p as Student).Ave1 == maxave ).ToList();
                if (listStudentMax.Count == 0)
                {
                    Console.WriteLine("~~~~~~~khong co sinh vien~~~~~~~~");

                }
                else
                {
                    foreach (Student s in listStudentMax)
                    {
                        s.Output();
                    }
                }
            }
            else if (chon == 2)
            {
                Teacher dsgv = new Teacher();
                Console.Write("Nhap so luong sinh vien: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    dsgv.Input();
                    ds.Add(dsgv);
                }
                foreach (Teacher tc in ds)
                {
                    tc.Output();
                }
                Console.WriteLine();
                Console.WriteLine("**********DANH SACH GIAO VIEN THUOC QUAN 9**************");
                List<Person> dsgvq9 = ds.Where(p=> (p as Teacher).Diachi1 == "Quận 9").ToList();
                if (dsgvq9.Count == 0)
                {
                    Console.WriteLine("~~~~~~~khong co giao vien~~~~~~~~");

                }
                else
                {
                    foreach (Teacher s in dsgvq9)
                    {
                        s.Output();
                    }
                }
                Console.WriteLine();
                Console.WriteLine("*************GIAO VIEN CO MA GIANG VIEN CHN060286*************");
                List<Person> gv = ds.Where(p => (p as Teacher).ID1 == "CHN060286").ToList();
                if (gv.Count == 0)
                {
                    Console.WriteLine("~~~~~~~khong co giao vien~~~~~~~~");

                }
                else
                {
                    foreach (Teacher s in gv)
                    {
                        s.Output();
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
