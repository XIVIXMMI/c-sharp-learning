


/*
    ?Class trong C#
        Chính là cách thể hiện khái niệm về lớp trong OOP
        Một lớp trong C# có các thành phần như thuộc tính, biến, 
        Phương thức là các hàm thành phần thể hiện hành vi của 1 lớp, Phương thức khởi tạo, phương thức huỷ bỏ
        Class thực ra là một kiểu dữ liệu mới do người dùng định nghĩa

    ?Khai báo khởi tạo class trong C#
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


    ?Phương thức khởi tạo
    ?Phương thức hủy bỏ
    ?So sánh class và struct 
*/