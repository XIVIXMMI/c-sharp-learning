using System;

namespace program
{
    class program{

    }
}
/*
    Enum là gì ? 
    Là từ khóa khai báo 1 kiểu liệt kê Enumeration
    Kiểu liệt kê là 1 tập hợp các hằng số do người dùng tự định nghĩa
    Nói cách khác enum là cách mà C# hỗ trợ người dùng gom nhóm các hằng số lại với nhau
    Đặc điểm Enum ?
    Là kiểu dữ liệu tham trị
    Không đc phép kế thừa

    KHAI BÁO:
    Syntax
    enum <tên enum> {
        <danh sách các biểu tượng hằng> 
    } 
    trong đó: 
    <tên enum> là tên kiểu liệt kê do mình tự đặt và tuân thủ theo quy tắc đặt tên
    <danh sách các biểu tượng hằng> là danh sách các biểu tượng hằng,
    thành phần mỗi biểu tượng hằng cách nhau bằng dấu " , ".

    Ví dụ: 

    enum Color{
        RED,
        BLUE,
        YELLOW
    }

    Nếu sử dụng khai báo hằng bình thường sẽ khai báo như sau
    public const int RED = 0;
    public const int BLUE = 1;
    public const int YELLOW = 2;

    SỬ DỤNG: 
    Có thể truy vấn đến từng biểu tượng của enum thông qua toán tử . kèm theo tên biểu tượng 

    Color.RED 

    LƯU Ý: 
    Mặc dù bản chất các biểu tượng hằng là đại diện cho các số nguyên 
    nhưng bạn không thể so sánh trực tiếp chúng với các số nguyên mà phải ép kiểu.
    enum Color{
        RED,
        BLUE,
        YELLOW
    }
    int Choose = int.Parse(Console.ReadLine());
    if(Choose == Color.RED) //Lỗi vì không thể so sánh trực tiếp 1 enum với 1 số nguyên 
    {
        Console.WriteLine("You choose red color");
    }
    Để chương trình không báo lỗi ta có thể ép kiểu biểu tượng cho hằng RED về kiểu int
    Choose == (int)Color.RED
    Chúng ta có thể ép kiểu ngược lại từ số nguyên sang kiểu liệt kê. 
    Color.Background = (Color)2; //Background sẽ có giá trị là Color.YELLOW 

    Khi khai báo 1 biến nào đó, các lập trình viên thường cố gắng xây dựng 1 tập các giá trị của biến đó
    (nếu có thể) và gom nhóm chúng bằng enum.
    Điều này rất thường gặp trong các bộ thư viện của C# và là sự khác biệt giữa C# và Java 

    ƯU ĐIỂM: 
    Vì được sử dụng với mục đích gom hằng có liên quan với nhau 
    nên khi sử dụng bạn không cần phải nhớ tên hằng mà chỉ cần nhớ tên enum chứa nó 
    
*/  