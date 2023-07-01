using System;
using System.Collections.Generic;
namespace TupleCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //var MyTuple = Tuple.Create<int, string>(11, "Billy");
            // var MyTuple = new Tuple<int, string>(11, "Billy");

            // Console.WriteLine("ID: {0}, Name: {1}", MyTuple.Item1, MyTuple.Item2);
            var now = GetCurrentDayMonthYear();
            Console.WriteLine("Day: {0}, Month: {1}, Year: {2}",now.Item1,now.Item2,now.Item3);
            Console.WriteLine(now.ToString());
        }
        static Tuple<int, int, int> GetCurrentDayMonthYear()
        {
            DateTime now = DateTime.Now;//lấy ngày giờ hiên tại của hệ thống 
            return new Tuple<int, int, int>(now.Day, now.Month, now.Year);
        }
    }
}

/*
Tuple là kiểu dữ liệu có cấu trúc, giúp lưu trữ các kiểu dữ liệu phức tạp mà không cần phải tạo ra một struct
hay một class mới.

C# cung cấp cho chúng ta 8 lớp generic:
public class Tuple<T1>
public class Tuple<T1,T2>
public class Tuple<T1,T2,T3>
public class Tuple<T1,T2,T3,T4>
public class Tuple<T1,T2,T3,T4,T5>
public class Tuple<T1,T2,T3,T4,T5,T6>
public class Tuple<T1,T2,T3,T4,T5,T6,T7>
public class Tuple<T1,T2,T3,T4,T5,T6,T7,TRest>
Mỗi lớp Tuple đã được định nghĩa sẵn các Property có tên Item1, Item2, Item3, 
...tương ứng các kiểu dữ liệu T1,T2, T3...được truyền vào
?Tuple được sử dụng khi nào đi đã có struct và class ?
=>Khi viết 1 phương thức và muốn trả về nhiều giá trị khi không có 1 class dựng sẵn
lúc này tuple dễ dàng giải quyết mà không cần tạo thêm struct hoặc class.

=>trong vài trường hợp cần tạo nhanh đối tượng và chỉ sử dụng 1 lần thì việc dùng struct hoặc class rất lãng phí
làm chương trình trở nên dài dòng, lúc đó tuple sẽ thay thế , chỉ cần lấy ra dùng không cần khai báo gì nữa

=>Ngoài ra Tuple đã override sẵn 
    *Phương thức Equals (phương thức dùng để so sánh 2 đối tượng)
    *Phương thức ToString (Phương thức chuyển giá trị đối tượn sang chuỗi)
    *Phương thức GetHashCode (Phương thức trả về hàm băm của 2 đối tượng, dùng để so sánh 2 đối tượng)

?Cách sử dụng 
*Cách 1: Thông qua phương thức Create trong lớp tuple
var MyTuple = Tuple.Creat<int,string>(11,"Billy");
*Thuộc tính thứ 1 có kiểu dữ liệu là int và giá trị là 11
*Thuộc tính thứ 2 có kiểu dữ liệu là string và giá trị là Billy

*Cách 2: Thông qua Constructor của các lớp generic 
var MyTuple = new Tuple<int,string>(11,"Billy");

TODO: Tuple cũng chỉ là 1 lớp bình thường đã được định nghĩa sẵn 
TODO: Vì vậy để giải quyết bài toán trả về nhiều giá trị cùng 1 lúc
TODO: Đơn giản chỉ cần khai báo kiểu trả về là 1 Tuple 

*/
