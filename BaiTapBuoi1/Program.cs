using Bai1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ds = new List<Student>();

            Console.Write("Nhap so luong sinh vien: ");
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap so sinh vien thu {0} ", i + 1);
                var sv = new Student();
                sv.Input();
                ds.Add(sv);
            }
            Console.WriteLine("***********DANH SACH SINH VIEN************");
            foreach (Student sv in ds)
            {
                sv.Output();
            }
            Console.WriteLine("**********DANH SACH SINH VIEN CNTT**************");
            List<Student> dssv = (from s in ds
                                  where s.Faculty1 == "CNTT"
                                  select s).ToList();
            if (dssv.Count() == 0)
                Console.WriteLine("khong co sinh vien nao");
            else
                foreach (Student sv in dssv)
                {
                    sv.Output();
                }

            Console.WriteLine("*************DANH SACH SINH VIEN LON HON 5 DIEM***************");
            List<Student> svlh5 = ds.Where(p => p.Ave1 >= 5).ToList();
            foreach (Student sv in svlh5)
            {
                sv.Output();
            }
            Console.WriteLine("*********** DANH SACH SINH VIEN DUOC SAP XEP DTB TANG DAN***************");
            List<Student> sapxep = ds.OrderBy(p => p.Ave1).ToList();
            foreach (Student sv in sapxep)
            {
                sv.Output();
            }
            Console.WriteLine("***********DANH SACH SINH VIEN CNTT CO DIEM LON HON 5*************");
            List<Student> cnttlh5 = ds.Where(p => p.Ave1 >= 5).Where(p => p.Faculty1 == "CNTT").ToList();

            foreach (Student sv in cnttlh5)
            {
                sv.Output();
            }
            Console.WriteLine("***********SINH VIEN CO DIEM TRUNG BINH CAO NHAT THUOC KHOA CNTT************");
            List<Student> ListCNTTStundent = ds.Where(p => p.Faculty1 == "CNTT").ToList();
            var maxave = ListCNTTStundent.Max(p => p.Ave1);
            var ListMaxStundent = ListCNTTStundent.Where(p => p.Ave1 == maxave).ToList();
            foreach (Student sv in ListMaxStundent)
            {
                sv.Output();
            }
            Console.ReadKey();
        }

    }
}