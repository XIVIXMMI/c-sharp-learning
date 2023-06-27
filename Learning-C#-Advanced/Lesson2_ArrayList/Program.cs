/*
?ArrayList là gì
Là 1 collection giúp lưu trữ và quản lý 1 danh sách các đối tượng theo kiểu mảng
truy cập các phần tử bên trong thông qua Index, bản chất giống mảng
Giống như mảng 1 các object nhưng có thể thêm hoặc xóa các phần tử một cách linh hoạt 
và có thể điều chỉnh kích cỡ mảng 1 cách tự động. (đây là điều mà arraylist làm được còn mảng thì không)
Để sử dụng Collection cần thêm thư viện bằng câu lệnh using System.Collection;
*Vì ArrayList là một vùng nhớ nên khi sử dụng cần tạo đối tượng mới bằng toán tử new
?Một số phương thức hỗ trợ sẵn trong ArrayList
!Một số thuộc tính thông dụng trong ArrayList
_____________________________________________________________________________________
|       Tên thuộc tính   |  Mô tả                                                   |
|________________________|__________________________________________________________|
|       Count            | Trả về số nguyên là phần tử hiện có trong ArrayList      |
|________________________|__________________________________________________________|
|       Capacity         |  Trả về số nguyên cho biết phần tử mà ArrayList          |
|                        |  có thể chứa(sức chứa).Nếu phần tử được thêm vào         |
|                        |  chạm sức chứ này thì hệ thống sẽ tự động tăng lên.      |
|                        |  Ngoài ra ta có thể gán sức chứa bất kì cho ArrayList    |
|________________________|__________________________________________________________|

!Một số phương thức thông dụng trong ArrayList
_____________________________________________________________________________________
|   Tên phương thức     |       Ý nghĩa                                             |
|_______________________|___________________________________________________________|
|   Add(object Value)   |   Thêm đối tượng value vào cuối ArrayList.                |
|_______________________|___________________________________________________________|
|       AddRange        |   Thêm danh sách phần tử ListObject vào cuối ArrayList.   |
|(ICollection LisObject)|                                                           |
|_______________________|___________________________________________________________|
|   BinarySearch        |   Tìm kiếm đối tượng value trong ArrayList theo thuật toán|
|   (object Value)      |   tìm kiếm nhị phân. Nếu tìm thấy trả về vị trí phần tử   |
|                       |   ngược lại trả về giá trị âm. Lưu ý ArrayList phải được  |
|                       |   sắp xếp trước khi sử dụng hàm.                          |
|_______________________|___________________________________________________________|
|       Clear()         |   Xóa tất cả phần tử trong ArrayList                      |
|_______________________|___________________________________________________________|
|       Clone()         |   Tạo bản sao từ ArrayList hiện tại                       |
|                       |   tương tự ArrayList Arr1 = new ArrayList(Arr2);          |
|_______________________|___________________________________________________________|
|       Constains       |   Kiểm tra đối tượng Value có tồn tại trong Arraylist     | 
|   (object Value)      |   hay không.                                              |
|_______________________|___________________________________________________________|
|       GetRange        |   Trả về 1 ArrayList bao gồm các phần tử từ vị trí        |
|(int StartIndex,       |   StartIndex cho đến vị trí EndIndex từ ArrayList ban đầu |
|   int EndIndex)       |                                                           |
|_______________________|___________________________________________________________|
|       IndexOf         |   Trả về vị trí đầu tiên xuất hiện Value trong ArrayList  |
|   (object Value)      |   nếu không tìm thấy trả về -1                            |
|_______________________|___________________________________________________________|
|   Insert(int Index,   |   Chèn đối tượng Value vào vị trí Index trong ArrayList   |
|    object Value)      |                                                           |
|_______________________|___________________________________________________________|
|InsertRange(int Index, |   Chèn danh sách ListObject vào vị trí Index trong        |
|ICollection ListObject)|   Arraylist.                                              |
|_______________________|___________________________________________________________|
|   LastIndexOf         |   Trả về vị trí xuất hiện cuối cùng của Value trong       |
|   (object Value)      |   ArrayList. Nếu không tìm thấy trả về -1                 |
|_______________________|___________________________________________________________|
| Remove(object Value)  |   Xóa Value đầu tiên trong ArrayList                      |
|_______________________|___________________________________________________________|
|    Reverser()         |   Đảo ngược tất cả phần tử trong ArrayList                |
|_______________________|___________________________________________________________|
|       Sort()          |   Sắp xếp các phần tử trong ArrayList theo thứ tự tăng dần|
|_______________________|___________________________________________________________|
|       ToArray()       |   Trả về mảng các object chứa phần tử được sao chép từ    |
|                       |                       ArrayList                           |
|_______________________|___________________________________________________________|

*Hàm Sort sẽ thực hiện sắp xếp danh sách theo thứ tự tăng dần,
*Vậy nếu danh sách là gồm các đối tượng mà mỗi đối tượng là 1 lớp có nhiều thuộc tính 
*Thì làm sao để hàm sort biết sắp xếp tăng dần theo thuộc tính nào? 

*=> Hàm Sort được hỗ trợ sẵn trong ArrayList có cú pháp như sau
    Sort(IComparer comparer)
    Hàm này cho phép người dùng tự định nghĩa cách sắp xếp theo ý mình 
    Tham số truyền vào là một lớp có thừa kế từ interface IComparer.
    Interface IComparer chứa phương thức duy nhất: int Comparer(object x,object y).

    phương thức này sẽ trả về 3 giá trị
    => Bé hơn 0 nếu x < y;
    => Lớn hơn 0 nếu x > y;
    => Bằng 0 nếu x = y;
Từ những quy định về interface này ta chỉ cần khai báo 1 lớp kế thừa interface IComparer và định nghĩa
nội dung cho phương thức Comparer có giá trị trả về theo những quy định trên.

TODO:lưu ý rằng việc sử dụng ArrayList không được khuyến nghị trong C# từ phiên bản .NET Framework 2.0 trở đi. 
TODO:Thay vào đó, bạn nên sử dụng generic List<T> để lưu trữ và xử lý danh sách các đối tượng.
*/
using System;
using System.Collections.Generic;
using ArrayList;
namespace ArrayList
{
    class Program{
        static void Main(string[]args){
            // #region Khởi tạo ArrayList
            // ArrayList firstArray = new ArrayList(); //khởi tạo ArrayList rỗng
            // ArrayList secondArray = new ArrayList(5); //Khởi tạo 1 ArrayList và chỉ định Capacity của nó là 5
            // /*
            // Khởi tạo ArrayList có kích thước bằng với secondArray
            // Sao chép toàn bộ phần tử trong secondArray vào thirdArray.
            // */
            // ArrayList thirdArray = new ArrayList(secondArray);
            // /*
            //     Khi khai báo như thế này thì sẽ clone ra được 1 vùng nhớ mới 
            //     lấy hết dữ liệu của secondArray để sử dụng
            // */
            // /*ArrayList fourthArray = secondArray;
            //     Khi khai báo như thế này thì mỗi khi secondArray thay đổi giá trị
            //     thì fourthArray cũng bị thay đổi giá trị theo 
            //     => 2 mảng này đang trỏ tới cùng 1 vùng nhớ nên giá trị vùng nhớ thay đổi thì cả hai cũng thay đổi
            // */
            // #endregion
            // #region Sắp xếp 1 danh sách object trong ArrayList
            // //Tạo 1 ArrayList rỗng
            // ArrayList arrPerson = new ArrayList();
            // //Thêm 3 person vào ArrayList()
            // arrPerson.Add(new Person("Nguyễn Văn A",30));
            // arrPerson.Add(new Person("Nguyễn Văn B",25));
            // arrPerson.Add(new Person("Nguyễn Văn C",20));
            // //In danh sách person ban đầu
            // Console.WriteLine("Danh sách người: ");
            // foreach (Person item in arrPerson)
            // {
            //     Console.WriteLine(item.ToString());
            // }
            // /*
            //     Thực hiện sắp xếp danh sách Person theo tiêu chí được định nghĩa
            //     Trong phương thức comparer của lớp SortPerson (tuổi tăng dần)
            // */
            // arrPerson.Sort(new SortPerson());
            // //In ra màn hình danh sách sau khi sắp xếp
            // Console.WriteLine();
            // Console.WriteLine("Danh sách tuổi tăng dần: ");
            // foreach (Person item in arrPerson)
            // {
            //     Console.WriteLine(item.ToString());
            // }
            // #endregion


            // Tạo 1 List rỗng
            List<Person> personList = new List<Person>();
        
            // Thêm 3 person vào List
            personList.Add(new Person("Nguyễn Văn A", 30));
            personList.Add(new Person("Nguyễn Văn B", 25));
            personList.Add(new Person("Nguyễn Văn C", 20));
        
            // In danh sách person ban đầu
            Console.WriteLine("Danh sách người: ");
            foreach (Person person in personList)
            {
                Console.WriteLine(person.ToString());
            }
        
            // Sắp xếp danh sách Person theo tuổi tăng dần
            personList.Sort(new SortPerson());
        
            // In ra màn hình danh sách sau khi sắp xếp
            Console.WriteLine();
            Console.WriteLine("Danh sách tuổi tăng dần: ");
            foreach (Person person in personList)
            {
            Console.WriteLine(person.ToString());
            }
        }
    }
    class SortPerson : IComparer<Person>
    {
        public int Compare(Person? x, Person? y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentNullException();
            }

            return x.Age.CompareTo(y.Age);
        }

        // public int Compare(object x, object y){
        //     //Ép kiểu 2 Object truyền vào về Person
        //     Person p1 = x as Person;
        //     Person p2 = y as Person;
        //     /*
        //     Vì có thể 2 Object truyền vào không phải person khi đó ta không thể so sánh được.
        //     Trường hợp này tốt nhất nên ném ra lỗi để lập trình viên sửa chữa
        //     */
        //     if(p1 == null || p2 == null){
        //         throw new InvalidOperationException();
        //     }else{
        //         /*
        //         Khi dữ liệu đã OK ta thực hiện so sánh và trả về giá trị -1 0 1 tương ứng
        //         lớn hơn, bằng, bé hơn
        //         */
        //         if(p1.Age < p2.Age){
        //             return 1;
        //         }else if (p1.Age == p2.Age){
        //             return 0;
        //         }else if (p1.Age > p2.Age){
        //             return -1; 
        //         }
        //     }
        // }

    }
}