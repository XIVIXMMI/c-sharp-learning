namespace Inheritance
{
    class Animal{
        protected int Weight;
        protected int Height;
        protected int Legs;
        public void Info(){
            Console.WriteLine("Weight: {0}\nHeight: {1}\nLegs: {2}",Weight,Height,Legs);
        }
        // #region từ khóa Base
        // /*Giả sử lớp animal có constructor có tham số như sau */
        // public Animal(double w,double h,int l){
        //     Weight = w;
        //     Height = h;
        //     Legs = l;
        // }
        // #endregion
    }
    class Cat : Animal{
        public Cat(){
            /*
            Lớp Cat được thừa kế các thuộc tính Weight,Height,Legs và phương thức Info từ Animal
            việc được thừa kế này là do các thuộc tính đều có phạm vi là protected và phương thức là public 
            do vậy lớp cat có thể sử dụng mà không cần khai báo 
            */
            Weight = 7;
            Height = 90;
            Legs = 4;
        }
        // #region từ khóa Base
        // /*Gọi constructor của lớp cha thông qua từ khóa base*/
        // public Cat(double w,double h,int l) : base (w,h,l){

        // }
        // #endregion
    }
    
    class Program{
        static void Main(string[]agrs){
            Cat BlackCat = new Cat();
            BlackCat.Info();
        }
    }
}

/*
?Kế thừa là gì
Là cách mà một lớp được thừa hưởng những phương thức thuộc tính từ 1 lớp khác
và sử dụng chúng như của bản thân mình.
*Ưu điểm :
*Cho phép xây dựng lớp mới từ lớp cơ sở đã có 
    =>Lớp mới gọi là lớp con (subclass) hay lớp dẫn xuất (derived class)
    =>Lớp đã có gọi là lớp cha (superclass) hay lớp cơ sở (base class)
*Cho phép chia sẻ thông tin chung nhằm tái sử dụng, đồng thời giúp ta dễ dàng nâng cấp, dễ dàng bảo trì
*Định nghĩa sự tương thích giữa các lớp, nhờ đó ta có thể chuyển kiểu dữ liệu tự động
?Khai báo và sủ dụng kế thừa 
syntax: 
class <tên lớp con> : <tên lớp cha> {

}
trong đó: 
<tên lớp con>: do người dùng đặt
<tên lớp cha>: tên lớp mà ta muốn thừa kế các đặt tính từ nó

!Lưu ý: 
!Trong C# không hỗ trợ đa kế thừa (1 lớp kế thừa từ nhiều lớp) nhưng lại hỗ trợ thực thi nhiều interface
!Các thành phần của lớp cha có được kế thừa xuống lớp con hay không là do phạm vi truy cập của thành phần 
!Thành phần có phạm vi là private thì không được kế thừa
!Thành phần có phạm vi protected, public thì được phép kế thừa
!Phương thức khởi tạo và phương thức hủy bỏ không được phép kế thừa

?Các vấn đề trong kế thừa
!Vấn đề phương thức khởi tạo và phương thức hủy bỏ 
Phương thức khởi tạo của lớp cha sẽ luôn được gọi mỗi khi có 1 đối tượng thuộc lớp con được khởi tạo
Và được gọi trước phương thức khởi tạo của lớp con
Nếu như lớp cha có phương thức khởi tạo có tham số thì đòi hỏi lớp con cũng có phương thức khởi tạo tương ứng
Và thực hiện gọi phương thức khởi tạo của lớp cha thông qua từ khóa BASE 
syntax:
public <tên lớp> (<danh sách tham số của lớp con>) : base (<danh sách tham số){

}
*Khi đối tượng của lớp con bị hủy thì phương thức hủy của nó sẽ được gọi đến lớp con trước
*Sau đó mới gọi đến phương thức hủy bỏ của lớp cha để hủy bỏ những gì mà lớp con không hủy được.

!Vấn đề hàm trùng tên và cách gọi phương thức của lớp cha
Giả sử lớp Animal có phương thức Info() và lớp Cat do được thừa kế nên cũng có phương thức này
Bây giờ trong lớp Cat ta tạo 1 phương thức cũng tên Info() có kiểu trả về là void và không có tham số truyền vào
    ?vậy câu lệnh sau sẽ gọi Info() nào 
    Cat BlackCat = new Cat();
    BlackCat.Info();

    => Câu trả lời là C# sẽ gọi lớp Info() do lớp Cat định nghĩa. Đồng thời cũng đưa ra cảnh báo khi biên dịch 
    => Trong C# có hỗ trợ từ khóa New nhằm đánh dấu đây là 1 hàm mới và hàm thừa kế từ lớp cha sẽ bị che đi khiến bên ngoài không thể gọi được.
    Cụ thể bạn có thể thêm từ khóa new vào ngay trước khai báo hàm Info() trong lớp Cat
    public void new Info(){

    }
    => khi đó hàm Info() của lớp cha bị che đi và các đối tượng bên ngoài chỉ gọi được new Info() của lớp Cat
    => từ khóa này chỉ làm tường minh khi khai báo hàm Info() chứ không làm thay đổi kết quả chương trình 

    ?Vậy có cách nào gọi hàm Info() của lớp cha được nữa không 
    =>Câu trả lời là có nhưng chỉ gọi trong nội bộ lớp Cat mà thôi 
    Bạn có thể sử dụng từ khóa base để đại diện cho lớp cha và gọi đến các thành phần của lớp cha 
    Ví dụ gọi hàm Info() của lớp cha
        public void new Info(){
            Console.WriteLine("Info of cats");
            base.Info(); // Gọi đến hàm Info() của lớp cha
    }
!Vấn đề về cấp phát vùng nhớ cho đối tượng 
    Bình thường nếu 1 đối tượng kiểu Animal không thể khởi tạo vùng nhớ có kiểu Cat được 

    Animal cat = new Cat();
    => câu lệnh này sẽ báo lỗi "Không thể chuyển kiểu dữ liệu Cat sáng kiểu Animal"
    Nhưng nếu 2 lớp này có quan hệ thừa kế thì hoàn toàn được 
    Tính chất này được phát biểu như sau: 
TODO:"Một đối tượng thuộc lớp cha có thể tham chiếu đến vùng nhớ của lớp con nhưng ngược lại thì không"
    Nghĩa là nếu lớp Cat thừa kế Animal thì câu lệnh Animal cat = new Cat(); hoàn toàn đúng
    nhưng ngược lại  Cat cat = new Animal(); sẽ báo lỗi.
    !Cần lưu ý điều này. Vì muốn thể hiện tính đa hình trong lập trình ta phải sử dụng tính chất này
*/
