using System;
using System.Collections.Generic;
using GenericCS;
namespace GenericCS
{
    class Program{
        /*
        Hàm hoán đổi 2 số nguyên kiểu dữ liệu int 
        */
        // public static void Swap(ref int a, ref int b){
        //     int temp = a;
        //     a = b;
        //     b = temp;
        // }
        /*
        Hàm hoán đổi sử dụng generic  <T> là tên tạm thời thay thế cho kiểu dữ liệu được truyền vào
        */
        public static void Swap<T>(ref T a, ref T b){
            T temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args){
            // int a = 10, b = 4; 
            // Console.WriteLine("Before swap: a = {0} b ={1}",a,b);
            // Swap<int>(ref a, ref b);//Khai báo kiểu dữ liệu trong < >
            // Console.WriteLine("After swap: a = {0} b ={1}",a,b);

            MyGeneric<int> myG = new MyGeneric<int>(5);
            myG.SetItemValue(0, 10);

        }
    }
}
/*
?Generic là gì 
Được đưa ra nhằm tái sử dụng lại mã nguồn, cho phép định nghĩa 1 hàm 1 lớp mà không cần chỉ ra đối số kiểu dữ liệu là gì
Tùy vào  kiểu dữ liệu mà người dùng truyền vào thì nó sẽ hoạt động theo kiểu dữ liệu đó  
=>Object thì chứa được mọi kiểu dữ liệu nên khó kiểm soát dược việc thêm phần tử có thuộc cùng kiểu dữ liệu hay không => khó quản lý 
=> Generic ra đời vì điều này, giúp ra vừa thực thi vừa hạn chế lỗi trong quá trình thực thi
?Một số loại Generic 
Các Generic collection đều được xây dựng từ 1 collection nào đó 
vì thế với mỗi collection sẽ có 1 generic tương ứng 

List<T>: Là 1 collection lưu trữ phần tử liên tiếp giống mảng, nhưng có khả năng tự mở rộng kích thước, 
=> Thay thế cho ArrayList đã học
Dictionary<TKey,TValue>: Lớp lưu trữ dữ liệu dưới dạng Key - Value, khi đó ta sẽ truy xuất các phần tử
thông qua Key => Thay thế cho HashTable
SortedList<Tkey,TValue>:là sự kết hợp của list và dictionary, tức là dữ liệu sẽ lưu trũ dưới dạng Key - Value
ta có thể truy xuất thông qua Key, hoặc thông qua index, đặc biệt là các phần tử trong danh sách được sắp xếp theo
giá trị của key. => Thay thế cho SortedList
Stack<T>: lớp cho phép thao tác và lưu trữ dữ liệu dưới dang LIFO
=> thay thế cho Stack
Queue<T>: lớp cho phép thao tác và lưu trữ dữ liệu dưới dạng FIFO
=> thay thế cho Queue
*/