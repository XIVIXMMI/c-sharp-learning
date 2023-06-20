using System;
namespace program
{
    class program{
        struct Student{
            public int ID;
            public string fullName;
            public double mathScore;
            public double physicScore;
            public double literatureScore;
        }

        static void Input(out Student Stu){
            Console.Write("Enter ID: ");
            Stu.ID = int.Parse(Console.ReadLine());
            Console.Write("Enter full name: ");
            Stu.fullName = Console.ReadLine();
            Console.Write("Enter math score: ");
            Stu.mathScore = Double.Parse(Console.ReadLine());
            Console.Write("Enter physic score: ");
            Stu.physicScore = Double.Parse(Console.ReadLine());
            Console.Write("Enter literature score: ");
            Stu.literatureScore = Double.Parse(Console.ReadLine());
        }
        /*Vì struct là kiểu dữ liệu tham trị nên khi truyền vào các phương thức
        thì giá trị của nó sau khi kết thúc phương thức sẽ không thay đổi, 
        do đó cần sử dụng từ khóa out để có thể cập nhật giá trị thay đổi khi kết thúc phương thức 
        */
        static void Output(Student Stu){
            Console.WriteLine("ID: "+ Stu.ID);
            Console.WriteLine("Full name: "+ Stu.fullName);
            Console.WriteLine("Math Score: "+ Stu.mathScore);
            Console.WriteLine("Physic Score: "+ Stu.physicScore);
            Console.WriteLine("Literature Score: "+ Stu.literatureScore);
        }
        static double AverageScore(Student Stu){
            return(Stu.mathScore + Stu.physicScore + Stu.literatureScore)/3;
        }
        static void Main(string[]agrs){
            Student student = new Student();
            Console.WriteLine("-------------INFORMATION STUDENT PROGRAM--------------");
            Console.WriteLine("Enter the information of student");
            Input(out student);
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("---------THE INFORMATION OF STUDENT CURRENTLY---------");
            Output(student);
            Console.WriteLine("The average score is: "+ AverageScore(student));
            Console.ReadLine();
        }
    }
}

/* Struct trong C#
    Struct là gì, kiểu dữ liệu của struct ?
    Struct là một kiểu dữ liệu có cấu trúc (class cũng thế)
    + Được kết từ những dữ liệu nguyên thủy được người lập trình định nghĩa
    để thuận tiện cho việc quản lý dữ liệu và nhập trình.
    tóm lại có thể hiểu, kiểu dữ liệu có cấu trúc là kiểu dữ liệu 
    được kết hợp từ nhiều kiểu dữ liệu nguyên thủy hoặc kiểu dữ liệu có cấu trúc khác !

    Struct là một kiểu dữ liệu tham trị ( kiểu dữ liệu tham trị xem ở bài kiểu dữ liệu C#)
    Struct không đươc phép kế thừa 

    KHAI BÁO VÀ SỬ DỤNG 

    struct <tên struct> {
        public <danh sách các biến>;
    }

    <tên struct> là tên kiểu dữ liệu 
    <danh sách các biến> là danh sách các biến được khai báo như biến bình thường
    từ khóa public chỉ định phạm vi truy cập (tính đóng gói)

    Ví dụ: 
    struct Student {
        public int ID;
        public string fullName;
        public double mathScore;
        public double physicScore;
        public double literatureScore;
    }


*/