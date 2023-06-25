
/*
TODO:Không kế hỗ trợ đa kế thừa từ abstract nhưng lại hỗ trợ implement nhiều interface

?Interface là gì tại sao phải sử dụng interface
*=> là tập hợp các phần chỉ có khai báo mà không có phần định nghĩa (giống như phương thức thuần ảo)
Các thành phần này có thể là 
*Phương thức
*Property (phải có get set): thành phần của 1 lớp hoặc cấu trúc của struct
*Event
*Indexers

*=> Một Interface được hiểu như là một lớp khuôn mẫu mà mọi lớp thực thi nó đều phải tuân theo.
*Interface sẽ định nghĩa phần "làm gì" (khai báo) và những lớp thực thi interface này sẽ định nghĩa 
*phần "làm thế nào" (định nghĩa nội dung) tương ứng.

!Đăc điểm của Interface
*Chỉ chứa khai báo không chứa phần định nghĩa (giống phương thức thuần ảo, nhưng không cần dùng từ khóa abstract).
*Việc ghi đè interface cũng không cần từ khóa override
*Không thể khai báo phạm vi truy cập cho các thành phần bên trong ìnterface, mặc định là public.
*Interface không chứa các thuộc tính(các biến) dù là hằng số hay biến tĩnh cũng không được. (chỉ chứa property không chứa field *trường dữ liệu*)
*Không có constructor và destructor
*Các lớp có thể thực thi nhiều interface cùng lúc ( ở một góc độ nào đó nó có thể là phương án thay thế đa kế thừa)
*Một interface có thể kế thừa nhiều interface khác nhưng không thể kế thừa bất kì lớp nào 

TODO: Interface đươc sử dụng với mục đích 
*Vì C# không hỗ trợ đa kế thừa nên việc interface ra đời được xem là một giải pháp cho việc đa kế thừa này.
*Trong một hệ thống việc trao đổi thông tin giữa các thành phần cần phải đồng bộ và có những thống nhất chung.
*Vì thế interface sẽ giúp chúng ta đưa ra những quy tắc chung mà bắt buộc các thành phần trong hệ thống phải làm theo
*mới có thể trao đổi thông tin với nhau được.

?Khai báo và sử dụng interface
Syntax:
interface <tên interface>{
    khai báo các thành phần bên trong interface 
}
!Lưu ý: để tránh nhằm lẫn với lớp kế thừa, người ta thường dùng thêm tiền tố I để nhận dạng
Ví dụ: IAnimal
*=> việc thực hiện interface hoàn toàn giống việc kế thừa từ 1 lớp 
!Lưu ý: Bạn phải định nghĩa toàn bộ phần nội dung cho tất cả thành phần trong interface 

?So sánh giữa abstract và interface 

!Những điểm giống nhau giữa interface và abstract:
*Đều có thể chứa phương thức thuần ảo (phương thức không cần định nghĩa)
*Đều không cần khởi tạo đối tượng

!Những điểm khác nhau:
_____________________________________________________________________________________________________________________
*INTERFACE*                                          | *ABSTRACT CLASS*                                             |
+Chỉ có thể chứa nhiều interface khác.               |+Có thể kế thừa từ 1 lớp và nhiều interface.                  |
+Chỉ có thể chứa khai báo và không có phần nội dung  |+Có thể chứa các thuộc tính và phương thức                    |
không thể chứa biến.                                 |bình thường bên trong.                                        |
+Không cần dùng từ khóa override để ghi đè.          |+Sử dụng từ khóa override để ghi đè                           |
+Không có constructor.                               |+Có constructor.                                              |
+Không có phạm vi truy cập, mặc định là public       |+Có thể khai báo phạm vi truy cập.                            |
+Dùng để định nghĩa 1 khuôn mẫu                      |+Dùng để định nghĩa cốt lõi, thành phần chung của lớp         |
hoặc 1 quy tắc chung.                                |và sử dụng cho nhiều đối tượng cùng kiểu.                     |
+Cần thời gian để tìm phương thức thực tế            |+Nhanh hơn so với interface.                                  |
tương ứng với lớp dẫn nên thời gian chậm hơn 1 chút. |                                                              |
+Khi thêm mới 1 khai báo cần tìm tất cả các lớp      |+Đối với abstract class, khi định nghĩa 1 phương thức mới,    |
thực thi interface này để định nghĩa nội dung cho    |có thể định nghĩa nội dung phương thức là rỗng,hoặc thực thi  |
phương thức mới.                                     |mặc định. Vì thế toàn bộ hệ thống vẫn chạy bình thường.       |
=====================================================================================================================
*/
namespace Interface
{
    interface ISpeak{
        /*
        Khai báo phương thức mà không cần định nghĩa
        */
        void Speak();
    }
    class Animal:ISpeak{ //Lớp Animal thưc thi ISpeak
        /*
        Định nghĩa nội dung cho phương thức trong Interface
        Phương thức trong interface phải được định nghĩa có phạm vi là public 
        Vì mặc định Speak trong ISpeak đã là public rồi 
        */
        public void Speak(){
            Console.WriteLine("Animal is speaking...");
        }
    }
    class Program{
        static void Main(string[]args){
            Animal cat = new Animal();
            cat.Speak();
        }
    }
}
