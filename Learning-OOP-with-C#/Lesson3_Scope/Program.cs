using System;
namespace Name
{
    /*Vì không có từ khóa cụ thể nên class Students sẽ có phạm vi là internal */
    class Students{
        /*Các thuộc tính đều mang phạm vi là private vì thế chỉ sử dụng nội bộ class, bên ngoài không truy cập được*/
        public string? ID;
        private string? fullName;
        private double mathScore;
        private double literatureScore;
        // public double literatureScore{
        //     get {return literatureScore;}
        //     set { literatureScore = value;}
        // }
        private double physicScore;
        
        // public double physicScore{
        //     get {return physicScore;}
        //     set {
        //         /*  Kiểm tra physicScore có thỏa mãn hay không
        //             Nếu có sẽ thực hiện gán vào thuộc tính private
        //             Nếu không sẽ không làm gì cả, điều này đảm bảo tính đúng đắn của dữ liệu*/
        //         if(value <= 10 || value >= 0){
        //             physicScore = value;
        //         }
        //     }
        // }
        /*  Phương thức này có phạm vi public nên có thể sử dụng từ bên ngoài 
            Vì phương thức này nằm trong lớp nên có thể sử dụng các thuộc tính private ở trên */
        public void AverageScore(){
            double AVG =  ( mathScore + literatureScore)/2;
            Console.WriteLine("Name: "+ fullName + "Average Score: "+ AVG);
        }
    }
    class Program{
        static void Main(string[]agrs){
            Students SV = new Students();
            SV.AverageScore();
        }
    }
}
/*
    ?Các loại pham vi truy cập và ý nghĩa
    Là cách mà người lập trình quy định về quyền được truy xuất đến các phần tử của lớp
    *public: Không hạn chế. Thành phần mang thuộc tính này có thể được truy cập ở bất kỳ nơi nào.
    *private: Thành phần mang thuộc tính này là thành phần tiêng tư chỉ có nội bộ bên trong lớp chứa nó có quyền truy cập 
    *protected: Tương tự như private ngoài ra còn có thể truy cập từ lớp dẫn xuất lớp chứa nó.
    *internal: Chỉ được truy cập trong cùng 1 Assembly (Nói cách khác là cùng project). Thuộc tính này thường được dùng cho class
    *protected internal: Tương tự như interanl ngoài ra còn có thẻ truy cập từ lớp dẫn xuất lớp chứa nó.
    !Lưu Ý: 
        !Nếu khai báo class mà không chỉ ra phạm vi cụ thể thì mặc định là internal.
        !Nếu khai báo thành phần bên trong lớp mà không chỉ ra phạm vi cụ thể thì phạm vu mặc định là private. 
    Tính đóng gói là 1 trong 4 đăc điểm của lập trình hướng đối tượng
    Có 2 ý chính:
    * Các dữ liệu và phương thức có liên quan với nhau được đóng gói thành các lớp để tiện cho việc quản lý và sử dụng.
    => Điều này được thể hiện qua việc xây dựng 1 class.
    * Đóng gói còn để che đậy một số thông tin và chi tiết cài đặt nội bộ để bên ngoài không thể nhìn thấy
    => Điều này thể hiện qua các phạm vi truy cập đã trình bày ở trên Cụ thể:
        *Các thuộc tính: 
        thường có phạm vi truy cập là private, đây là thông tin nội bộ của lớp không thể truy cập tùy tiện
        *Các phương thức:
        thường có phạm vi là public, vì đây là hành vi(thao tác) chính mà lớp hỗ trợ cho chúng ta thực hiện những công việc những định 
        nên cần phải cho phép mọi người có thể sử dụng được.
    ?Phương thức truy vấn và Phương thức cập nhật
    Vấn đề đặt ra là nếu các thuộc tính bên trong class là private thì người dùng bên ngoài muốn thay đổi giá trị thì phải làm sao?
    => Thông qua Phương thức cập nhật và Phương thức truy vấn!
    *Phương thức truy vấn là phương thức giúp người dùng có thể xem được dữ liệu của một thuộc tính, 
    cụ thể phương thức truy vấn chỉ cần trả về giá trị của thuộc tính tương ứng.
    *Phương thức cập nhật là phương thức giúp người dùng có thể cập nhật, thay đổi giá trị của một thuộc tính nào đó, 
    cụ thể phương thức cập nhật chỉ cần thực hiện cập nhật giá trị mới cho thuộc tính tương ứng. 
    ( có thể kiểm tra tính đúng đắn của dữ liệu trước khi truyền vào )
    !Một số quy ước nhỏ về cách đặt tên 
    *Những phương thức truy vấn nên bắt đầu bằng từ khóa get + tên thuộc tính tương ứng (getFullName, getID ...)
    *Những phương thức cập nhật nên bắt đầu bằng từ khóa set + tên thuộc tính tương ứng (setFullName, setID ...)
    *Nếu thuộc tính kiểu luận lý (boolean) thì tên phương thức truy vấn nên bắt đầu bằng từ khóa is + tên thuộc tính tương ứng
    *Phương thức truy vấn sẽ có kiểu dữ liệu trả về trả về trùng với kiểu dữ liệu của thuộc tính tương ứng và không có tham số truyền vào
    *Phương thức cập nhật trả về sẽ có kiểu trả về là void và có 1 tham số truyền vào và có kiểu dữ liệu trùng với kiểu dữ liệu thuộc tính tương ứng.
    ?Từ khóa get và set
*/