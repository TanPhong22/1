using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Person
    {
        private string ID;
        private string FullName;
        public Person()
        {

        }
        public Person(string iD, string fullName)
        {
            ID = iD;
            FullName = fullName;
        }

        public string ID1
        {
            get
            {
                return ID;
            }

            set
            {
                ID = value;
            }
        }

        public string FullName1
        {
            get
            {
                return FullName;
            }

            set
            {
                FullName = value;
            }
        }
        public virtual void Input()
        {
            Console.Write("Nhap Ma So: ");
            ID = Console.ReadLine();
            Console.Write("Nhap Ho Va Ten: ");
            FullName = Console.ReadLine();
        }
        public virtual void Output()
        {
            Console.Write("Ma So : {0}", ID);
            Console.Write("Ho Va Ten: {0}", FullName);
        }
    }
}
