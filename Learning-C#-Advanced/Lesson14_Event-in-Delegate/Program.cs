using System;
using System.Collections;

namespace Event_Voi_Delegate
{
    public delegate void UpdateNameHandler(string name);
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.Unicode;

            HocSinh hs = new HocSinh();

            hs.NameChanged += Hs_NameChanged;
            //Anonymous methods
            //hs.NameChanged += (s)=>{ };

            hs.Name = "Kteam";
            Console.WriteLine("Tên từ class: " + hs.Name);
            hs.Name = "HowKteam.com";
            Console.WriteLine("Tên từ class: " + hs.Name);

            
        }

        private static void Hs_NameChanged(string name)
        {
            Console.WriteLine("Tên mới: " + name);
        }
    }

    public class HocSinh
    {
        public event UpdateNameHandler NameChanged;

        private string _Name;
        public string Name
        {
            get => _Name;
            set
            {
                _Name = value;
                if(NameChanged != null)
                {
                    NameChanged(Name);
                }
            }
        }
    }
}


/*
?Event là gì?
Event là 1 cơ chế xây dựng dựa trên cơ sở của delegate
Tạo ra giao tiếp và thông báo giữa các phương thức trong hệ thống.
?Khai báo Event trong C#
*Syntax: event <Kiểu delegate> <tên event>;
event UpdateNameHandler NameChanged;
?Khởi tạo Event trong C#
?Cách dùng Event trong C#
*/
