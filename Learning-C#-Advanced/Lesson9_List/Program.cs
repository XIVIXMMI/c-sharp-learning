using System.Collections.Generic;
using System;
namespace ListGenericCS
{
    class Program{
        static void Main(string[] args) {

            //khai báo List
            // List<int> list = new List<int>();
            // List<int> list2 = new List<int>(5);
            // List<int> list3 = new List<int>(list2);

            //Sử dụng List
            List<string> list4 = new List<string>();
            list4.Add("Billy");
            list4.Add("Jocelyn");
            list4.Add("Whisper");

            //in gia tri phan tu ban dau
            Console.WriteLine("Number of current element in List: {0} ",list4.Count);
            foreach (string item in list4) {
                Console.WriteLine(" "+item);
            }
            Console.WriteLine();

            //chen phan tu vao dau list
            list4.Insert(0, "Korin");
            //in lai gia tri sau khi chen
            Console.WriteLine("Number of current element in List: {0} ",list4.Count);
            foreach (string item in list4) {
                Console.WriteLine(" "+item);
            }
            Console.WriteLine();

            //kiem tra phan tu co ton tai trong list hay khong
            bool isExists = list4.Contains("Joce");
            if (isExists == false) {
                Console.WriteLine("The data is not exist");
            }else{
                Console.WriteLine("The data is OK");
            }
        }
    }
}
/*
?List trong C#
Là 1 Generic collection thay thế cho ArrayList trong collection
Lữu trữ và quản lý 1 danh sách các đối tượng theo kiểu mảng
Truy xuất thông qua index 
?Một số phương thức và thuộc tính 
!Thuộc tính:
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

!Phương thức:
_____________________________________________________________________________________
|   Tên phương thức     |       Ý nghĩa                                             |
|_______________________|___________________________________________________________|
|   Add(object Value)   |   Thêm đối tượng value vào cuối ArrayList.                |
|_______________________|___________________________________________________________|
|       AddRange        |   Thêm danh sách phần tử ListObject vào cuối ArrayList.   |
|(ICollection LisObject)|                                                           |
|_______________________|___________________________________________________________|
|   BinarySearch        |   Tìm kiếm đối tượng value trong List theo thuật toán     |
|       (T Value)       |   tìm kiếm nhị phân. Nếu tìm thấy trả về vị trí phần tử   |
|                       |   ngược lại trả về giá trị âm. Lưu ý List phải được       |
|                       |   sắp xếp trước khi sử dụng hàm.                          |
|_______________________|___________________________________________________________|
|       Clear()         |   Xóa tất cả phần tử trong ArrayList                      |
|_______________________|___________________________________________________________|
|       Constains       |   Kiểm tra đối tượng Value có tồn tại trong list          | 
|       (T Value)       |   hay không.                                              |
|_______________________|___________________________________________________________|
|   CopyTo(T[] arr,     |   Thực hiện sao chép các phần tử trong List sang mảng một |
|    int Index)         |   chiều arr từ vị trí Index của arr, lưu ý arr phải là    |
|                       |   mảng kiểu T tương ứng                                   |
|_______________________|___________________________________________________________|
|       GetRange        |   Trả về 1 ArrayList bao gồm các phần tử từ vị trí        |
|(int StartIndex,       |   StartIndex cho đến vị trí EndIndex từ ArrayList ban đầu |
|   int EndIndex)       |                                                           |
|_______________________|___________________________________________________________|
|       IndexOf         |   Trả về vị trí đầu tiên xuất hiện Value trong List       |
|       (T Value)       |   nếu không tìm thấy trả về -1                            |
|_______________________|___________________________________________________________|
|   Insert(int Index,   |   Chèn đối tượng Value vào vị trí Index trong List        |
|    T Value)           |                                                                |
|_______________________|___________________________________________________________|
|InsertRange(int Index, |   Chèn danh sách ListObject vào vị trí Index trong List   |
|ICollection ListObject)|                                                           |
|_______________________|___________________________________________________________|
|   LastIndexOf         |   Trả về vị trí xuất hiện cuối cùng của Value trong       |
|   (T Value)           |   List. Nếu không tìm thấy trả về -1                      |
|_______________________|___________________________________________________________|
| Remove(T Value)       |   Xóa Value đầu tiên trong List                           |
|_______________________|___________________________________________________________|
|    Reverse()          |   Đảo ngược tất cả phần tử trong List                     |
|_______________________|___________________________________________________________|
|       Sort()          |   Sắp xếp các phần tử trong List theo thứ tự tăng dần     |
|_______________________|___________________________________________________________|
|       ToArray()       |   Trả về mảng các object chứa phần tử được sao chép từ    |
|                       |                            List                           |
|_______________________|___________________________________________________________|

TODO: Khi List<> có kiểu dữ liệu truyền vào là object "List<object>" thì nó sẽ là 1 ArrayList 
*/
