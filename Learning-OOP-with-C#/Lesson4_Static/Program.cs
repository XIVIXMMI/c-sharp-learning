
/*
Ví dụ ta muốn quản lý số lượng mèo đang có(giả sử một đối tượng tạo ra là 1 con mèo)
*/
namespace Static
{
    class Cat{
        private int weigth;
        public int Weigth{
            get {return weigth;}
            set {weigth = value;}
        }
        private int heigth;
        public int Heigth{
            get {return heigth;}
            set {heigth = value;}
        }
        /*
        Khai báo biến static Count để lưu số lượng mèo hiện tại
        Mỗi lần có 1 đối tượng tạo ra sẽ tăng Count lên 
        */
        public static int Count = 0;
        public Cat(){
            weigth = 7;
            heigth = 20;
            /*Vì constructor chỉ được gọi khi có đối tượng tạo ra nên ta sẽ tăng count ở đây*/
            Count++;
        }
    }
    class Color{
        //Giả sử màu chủ đạo là 1 chuỗi ký tự lưu tên màu sắc tương ứng
        public static string colorToday;
        //Dùng static constructor để kiểm tra ngày hiện tại và khởi tạo giá trị cho biến tĩnh colorToday
        static Color(){
            /*Khai báo đối tượng ngày giờ và lấy giá trị hiệnt tại của hệ thống */
            DateTime now = DateTime.Now;
            /*Lấy ra thứ của ngày hiện tại và so sánh với 7 ngày trong tuần */
            switch (now.DayOfWeek){
                case DayOfWeek.Friday: 
                colorToday = "Black";
                break;
                case DayOfWeek.Monday: 
                colorToday = "Red";
                break;
                case DayOfWeek.Saturday: 
                colorToday = "Yellow";
                break;
                case DayOfWeek.Sunday: 
                colorToday = "White";
                break;
                case DayOfWeek.Thursday: 
                colorToday = "Green";
                break;
                case DayOfWeek.Tuesday: 
                colorToday = "Blue";
                break;
                case DayOfWeek.Wednesday: 
                colorToday = "Pink";
                break;
                default:
                colorToday = "Unknown";
                break;
            }
        }
    }
    class Calculator{
        public static long exponential(int radix, int exponent){
            long result = 1;
            for (int i = 0; i < exponent; i++){
                result *= radix;
            }
            return result;
        }
    }
    class Program{
        static void Main(string[]agrs){
            Console.WriteLine("Initial numbers of cat: "+Cat.Count);
            Cat BlackCat = new Cat();//tạo ra con mèo đầu tiên 
            Console.WriteLine("Current numbers of cat: "+Cat.Count);
            Cat WhiteCat = new Cat();//tạo ra con mèo thứ 2
            Console.WriteLine("Current numbers of cat: "+Cat.Count);
            /*
            Khi sử dụng biến Count ta gọi trực tiếp qua tên lớp Cat.Count 
            Chứ không gọi thông qua Instance "BlackCat" "WhiteCat" 
            Mỗi instance đại diện cho lớp Cat
            */
            Console.WriteLine("The resutl is: "+Calculator.exponential(2,3));

            Console.WriteLine("The color of day is: "+ Color.colorToday);
        }
    }
}
/*
Static - thành viên tĩnh 
?Đặc điểm 
!Bình thường các thuộc tính, phương thức có đặc điểm:
    *Chỉ có thể sử dụng sau khi khởi tạo đối tượng.
    *Dữ liệu thuộc về riêng mỗi đối tượng.
    (xét cùng 1 thuộc tính thì các đối tượng khác nhau thì thuộc tính đó sẽ mang các giá trị khác nhau)
    *Được gọi thông qua tên của đối tượng.
Đôi lúc người lập trình mong muốn một thuộc tính nào đó dùng chung cho mọi đối tượng
(Chỉ được cấp phát 1 vùng nhớ duy nhất) => từ đó khái niệm thành viên tĩnh - static ra đời.
!Đặc điểm của thành viên tĩnh:
    *Được khởi tạo 1 lần duy nhất ngay khi biên dịch chương trình 
    *Có thể dùng chung cho mọi đối tượng
    !Được gọi thông qua tên lớp 
    *Được hủy khi chương trình kết thúc
Có 4 loại thành viên tĩnh:
    *Biến tĩnh (static variable)
    *Phương thức tĩnh (static method)
    *Lớp tĩnh (static class)
    *Phương thức khởi tạo tĩnh (static constructor)
?Biến tĩnh
Syntax:
<phạm vi truy cập> static <kiểu dữ liệu> <tên biến> = <giá trị khởi tạo>;
trong đó:
    <phạm vi truy cập> là phạm vi như public, private, internal, protected, protected internal 
    <kiểu dữ liệu> là kiểu dữ liệu của biến như int, float, double, string, bool ...
    <tên biến> do người dùng đặt
    <giá trị khởi tạo> là giá trị ban đầu mà biến tĩnh này chứa, nếu không gán giá trị này
    thì C# tự gán giá trị mặc định và đưa ra cảnh báo khi chương trình biên dịch.

*=> Có thể hiểu biến tĩnh là 1 biến dùng chung cho mọi đối tượng thuộc lớp.
*=> Được khởi tạo 1 lần duy nhất khi chương trình nạp vào bộ nhớ để thực thi và hủy khi kết thúc chương trình.

Ngoài biến tĩnh ra thì hằng số cũng có thể gọi thông qua tên lớp và không cần khởi tao đối tượng,
nhưng biến tĩnh linh hoạt hơn đó là có thể khởi tạo đối tượng khi cần thiết.
Về cách sử dụng thì cứ sử dụng như biến thông thường nhưng phải nhớ là gọi thông qua tên lớp

?Phương thức tĩnh
Syntax:
<phạm vi truy cập> static <kiểu trả về> <tên phương thức> {
    nội dung phương thức;
}
*Hàm tĩnh là một hàm dùng chung của lớp, được gọi thông qua tên lớp, không cần khởi tạo đối tượng, tránh lãng phí bộ nhớ.
*Hỗ trợ việc viết lại các hàm tiện ích để sử dụng lại.
=> thao tác như hàm bình thường nhưng phải gọi thông qua tên lớp.
?Lớp tĩnh 
Syntax:
<phạm vi truy cập> static class <tên lớp> {
    các thành phần;
}
!Đặc điểm:
!Chỉ chứa thành phần, phương thức tĩnh
!Không thể khai báo biến, khởi tạo đối tượng thuộc lớp tĩnh
=> Có thể thấy lớp tĩnh được dùng với mục đích khai báo 1 lớp tiện ích, chứa các hàm tiện ích hoặc hằng số
*Ràng buộc các thành phần bên trong lớp static phải là static 
*Không cho phép tạo ra các đối tượng dư thừa làm lãng phí bộ nhớ
*Mọi thứ đều được truy cập thông qua tên lớp
?Phương thức khởi tạo tĩnh
Syntax:
static <tên lớp>(){
    Nội dung của constructor;
}
!Đặc điểm: 
!Không được phép khai báo phạm vi truy cập. Nếu cố tình làm điều này, C# sẽ báo lỗi khi biên dịch (access modifiers are not allowed on static constructor)
!Constructor tĩnh sẽ được gọi 1 lần duy nhất khi chương trình được nạp vào bộ nhớ để thực thi như là 1 cách để ta thiết lập thông số theo ý muốn trước khi có bất kì đối tượng nào được tạo ra
!Constructor tĩnh cũng giống như Phương thức tĩnh không thể gọi các thuộc tính không phải static
*/
