using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class
{
    class Animal{
        public double Weight;
        public double Height;

        public void Info(){
            /*Các phương thức bên trong lớp có thể gọi đến các thành phần khác
            (bao gồm thuộc tính và phương thức) trong lớp đó */
            Console.WriteLine(" Height: "+ Height+" Weight: "+Weight);
        }
    }
    class Cat{
        public double Height;
        public double Weight;
        public Cat(){
            Weight = 7;
            Height = 50;
        }
        /*deconstructor*/
        ~Cat(){

        }
        /*Constructor có tham số */
        public Cat(int w, int h){
            Weight = w;
            Height = h;
        }
        public void Info(){
            Console.WriteLine(" Height: "+ Height+" Weight: "+Weight);
        }
    }
    class Program{
        static void Main(string[]args){
            // Animal Dog = new Animal();
            // Dog.Weight = 7;
            // Dog.Height = 90;
            // Dog.Info();
            Cat BlackCat = new Cat();
            BlackCat.Info();
            Cat WhiteCat = new Cat(1200,30);
            WhiteCat.Info();

        }
    }
}
/*
    ?Class trong C#
        Chính là cách thể hiện khái niệm về lớp trong OOP
        Một lớp trong C# có các thành phần như thuộc tính, biến, 
        Phương thức là các hàm thành phần thể hiện hành vi của 1 lớp, Phương thức khởi tạo, phương thức huỷ bỏ
        Class thực ra là một kiểu dữ liệu mới do người dùng định nghĩa

    ?Khai báo khởi tạo class trong C#
    *Khai báo 
    class <tên lớp> {
        <phạm vi truy cập> <Các thành phần của lớp>;
    }
    trong đó: 
    <tên lớp> là tên do người dùng đặt
    <Phạm vi truy cập> bao gồm các từ khóa như public, protected, private, static,... 
    <Các thành phàn> bao gồm các biến, phương thức.

    Ví dụ:
    class Animal{
        public double Weight;
        publoc double Height;

        public void Run(){
            Console.WriteLine("Animal is running...");
        }
    }
    Với khai báo trên ta đã có 1 kiểu dữ liệu mới là Animal, và ta hoàn toàn có thể khai báo và sử dụng nó
    *Từ khóa public chỉ ra phạm vi truy cập của các thành phần bên trong class
    Lớp Animal có 2 thuộc tính là Weight, Height và 1 phương thức là Run, như vậy mọi đối tượng thuộc lớp này đều có 3 thành phần trên
    
    *Khởi tạo 
    Có thể khởi tạo 1 đối tượng thuộc lớp thông qua toán tử new 
    Animal Dog = new Animal();
    Class là kiểu dữ liệu tham chiếu vì vậy đối tượng dữ liệu thực sự được lưu trên heap 

    *Sử dụng 
    Về cơ bản thì class được sử dụng tương tự như struct.
    Để gọi đến các thuộc tính bên trong lớp:
    <tên đối tượng>.<tên thuộc tính>;
    Để gọi đến các phương thức bên tỏng lớp:
    <tên đối tượng>.<tên phương thức>(<danh sách tham số nếu có>);


    ?Phương thức khởi tạo
    *Constructor 
    Là những phương thức đặc biệt được gọi tới ngay khi khởi tạo đối tượng 
    cụ thể nó là 
    Animal(); còn được gọi là default constructor( hàm dựng mặc định)
    Đặc điểm: có tên trùng với tên lớp, không có kiểu trả về, được tự động gọi khi 1 đối tượng thuộc lớp được khởi tạo 
    Nếu không khai báo bất kì phương thức khởi tạo nào thì hệ thống sẽ tự động tạo một phương thức khởi tạo không đối số và không nội dung
    Có thể có nhiều constructor trong 1 lớp.
    có 2 ptkt là 
    *ptkt không đối số 
        không có bất kì tham số truyền vào thường dùng để khởi tạo các giá trị măc định cho các thuộc tính trong class 
        khi khởi tạo đối tượng giá trị mặc định này sẽ do người dùng quyết định 
    *ptkt có đối số là ptkt có đối số truyền vào và khi khởi tạo đối tượng, phương thức này được gọi ta cần truyền đầy đủ tham số 
        thường dùng để khởi tạo các giá trị cho các thuộc tính bên trong class khi khởi tạo đối tượng, các giá trị do người khởi tạo truyền vào 

    ?Phương thức hủy bỏ
    *Destructor
    Là phương thức đặc biệt được gọi đến khi bạn thu hồi (nghĩa là không xài nữa thì tự động thu hồi)
    Đặc điểm có tên trùng với tên lớp,  nhưng để phân biệt với constructor thì nên thêm dấu ngã "~" vào trước tên lớp
    Không có kiểu trả về
    Tự động gọi khi 1 đối tượng của nó kết thúc vòng đời bằng bộ thu dọn rác tự động gọi là gabage collection 
    Nếu không khai báo destructor thì hệ thống sẽ tự khai báo 1 destructor mà không có nội dung gì hết
    Chỉ có 1 destructor duy nhất trong 1 class
    Vì bộ gabage collection trong C# có cơ chế tự động phát hiện đối tượng không còn được sử dụng nữa, thực hiện thu hồi vùng nhớ của nó 
    Nên bạn không cần phải viết tường minh việc hủy vùng nhớ, việc bạn làm là viết những việc bạn làm khi đối tượng bị hủy vào đây.

    ?So sánh class và struct 
    Stuct                                                               Constructor
    + Kiểu tham trị                                                    | + Kiểu tham chiếu
    + Không có destructor                                              | + Có destructor
    + Không thể khai báo phương thức khởi tạo mặc định (không đối số)  | + Có thể khai báo phương thức khởi tạo mặc định
    + Không có khả năng kế thừa                                        | + Có thể kế thừa

    Ngoài ra nếu 1 class là tham số truyền vào thì mọi thay đổi bên trong hàm sẽ tự động cập nhật ra bên ngoài
    cho dù không có từ khóa ref hoặc out còn struct thì không 
*/