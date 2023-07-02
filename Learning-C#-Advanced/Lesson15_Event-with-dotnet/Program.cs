using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.Unicode;

            HocSinh hs = new HocSinh();
            hs.NameChanged += Hs_NameChanged;
            hs.Name = "Tên lần 1";
            hs.Name = "Tên lần 2";
            hs.Name = "Tên cuối";

            Console.ReadLine();
        }
        private static void Hs_NameChanged(object sender, NameChangedEventArgs e)
        {
            Console.WriteLine("Tên có thay đổi: " + e.Name);
        }
    }
    public class HocSinh
    {
        private string _Name;
        public string Name
        {
            get => _Name;
            set
            {
                _Name = value;
                OnNameChanged(value);
            }
        }
        private event EventHandler<NameChangedEventArgs> _NameChanged;
        public event EventHandler<NameChangedEventArgs> NameChanged
        {
            add
            {
                _NameChanged += value;
            }
            remove
            {
                _NameChanged -= value;
            }
        }

        void OnNameChanged(string name)
        {
            if(_NameChanged != null)
            {
                _NameChanged(this, new NameChangedEventArgs(name));
            }
        }
    }
    public class NameChangedEventArgs : EventArgs
    {
        public string Name { get; set; }
        public NameChangedEventArgs(string name)
        {
            Name = name;
        }
    }
}
/*
?Event chuẩn .Net là gì?
    Delegate có kiểu trả về là void
    Delegate có hai tham số, tham số thứ nhất có kiểu dữ liệu là object, tham số thứ hai có kiểu EventArgs. 
    object chính là đối tượng phát sinh sự kiện, EventArgs chính là class giữ thông tin 
    mà đối tượng gửi kèm trong quá trình phát sinh sự kiện.
    Lúc này thay vì chúng ta dùng Delegate do chúng ta tự tạo 
    thì .Net có sẵn Delegate tên là EventHandler theo chuẩn ở trên.
?Cách dùng Event chuẩn .Net trong C#
?Dùng Event chuẩn .Net với tham số truyền vào trong C#
*/
