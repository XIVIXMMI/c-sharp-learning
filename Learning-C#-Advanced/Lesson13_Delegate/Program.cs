using System;
using System.Collections;
using System.Text;
namespace Program
{
    class Program
    {
        delegate int MyDelegate(string s);
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.Unicode;

            // MyDelegate convertToInt = new MyDelegate(ConvertStringToInt);

            MyDelegate showString = new MyDelegate(ShowString);

            // MyDelegate multicast = convertToInt + showString;

            // string numberSTR = "35";

            // int valueConverted = convertToInt(numberSTR);

            // Console.WriteLine("Giá trị đã convert thành int: " + valueConverted);
            // Console.WriteLine("Kết quả khi gọi multicast Delegate");
            // multicast(numberSTR);
            NhapVaShowTen(showString);

            Console.ReadLine();
        }

        static int ConvertStringToInt(string stringValue)
        {
            int valueInt = 0;

            Int32.TryParse(stringValue, out valueInt);
            Console.WriteLine("Đã ép kiểu dữ liệu thành công");

            return valueInt;
        }
        static int ShowString(string stringValue)
        {
            Console.WriteLine(stringValue);
            return 0;
        }
        static void NhapVaShowTen(MyDelegate showTen)
        {
            Console.WriteLine("Mời nhập tên của bạn:");
            string ten = Console.ReadLine();
            showTen(ten);
        }
    }
}
/*
?Delegate là gì
Tương tự như con trỏ trong C và C++
Là 1 biến kiểu tham chiếu (references) chứa tham chiếu tới 1 phương thức 
Tham chiếu của delegate có thể thay đổi runtime (khi chương trình đang chạy)
=>Delegate là 1 biến kiểu tham chiếu, nhưng nó lại tham chiếu đến 1 hàm hoặc 1 phương thức 
Thường được dùng để triển khai phương thức hoặc sự kiện callback
=>Được dẫn xuất từ lớp System.Delegate trong C#
?Khai báo Delegate trong C#
Tương tự như khai báo 1 biến nhưng cần có từ khóa Delegate để xác định biến này là delegate
Delegate tham chiếu đến 1 hàm nên cần khai báo kiểu trả về,tham số đầu cho delegate tương ứng với hàm tham chiếu
*Syntax: delegate<kiểu trả về> <tên delegate> (<tham số đầu vào>);
            delegate int MyDelegate (string s);
        !Lưu ý: Chữ Delegate viết thường 
?Khởi tạo Delegate trong C#
Khi kiểu Delegate được khai báo, đối tượng Delegate phải được tạo với từ khóa new và được tham chiếu đến một phương thức cụ thể. 
Phương thức này phải cùng kiểu trả về và tham số đầu vào với Delegate đã tạo.

Khi tạo một Delegate, tham số được truyền với biểu thức new được viết tương tự như một lời gọi phương thức, nhưng không có tham số tới phương thức đó. 
Tức là chỉ truyền tên hàm vào thôi. 
Delegate sẽ tự nhận định hàm được đưa vào có cùng kiểu dữ liệu trả ra và cùng tham số đầu vào hay không
*Ví dụ: 
    MyDelegate convertToInt = new MyDelegate(ConvertStringToInt);

    static int ConvertStringToInt(string stringValue)
        {
            int valueInt = 0;

            Int32.TryParse(stringValue, out valueInt);
Console.WriteLine("Đã ép kiểu dữ liệu thành công");

            return valueInt;        
        }

    => Vậy Delegate bản chất chỉ là một biến thay thế cho hàm, 
    biến này tham chiếu đến hàm nó muốn tham chiếu để thay thế khi dùng. 
    Cách dùng y như gọi một hàm.
?Multicast(đa hướng) một Delegate trong C#
Khi cần thực hiện gọi 1 chuỗi hàm với cùng kiểu dữ liệu trả về và cùng tham số đầu vào 
mà không muốn gọi hàm tuần tự (chỉ gọi 1 hàm duy nhất), lúc này cần đến multicast delegate
Bản chất bạn có thể gọi 1 chuỗi delegate cùng kiểu delegate bằng toán tử +
Lúc này khi bạn gọi delegate nó sẽ thực hiện delegate tuần tự được cộng vào với nhau
?Dùng Delegate như một call-back function
Do delegate cũng là 1 biến.
Vậy nên mình có thể truyền Delegate vào hàm làm parameter như biến bình thường. 
Lúc này Delegate này sẽ được gọi là call-back function. 
Mục đích của việc này là hàm nhận call-back function là param có thể gọi Delegate được đưa vào khi nào cần 

TODO: Bạn cứ hiểu Delegate là một biến bình thường, biến này chứa hàm mà bạn cần gọi. 
TODO: Sau này lôi ra sài như hàm bình thường. Giá trị của biến Delegate lúc này là tham chiếu đến hàm. 
TODO: Có thể thay đổi runtime khi chương trình đang chạy.
TODO: Delegate không thể khai báo trong hàm được, chỉ có thể khai báo trong phạm vi Class 
TODO: Phải thỏa mãn điều kiện là cùng kiểu dữ liệu trả về và kiểu dữ liệu tham chiếu của hàm được truyền vào khi multicast
TODO: Khi multicast delegate chỉ gọi tuần tự output của các hàm chứ không dùng giá trị hàm trước đưa vào hàm sau 


*/
