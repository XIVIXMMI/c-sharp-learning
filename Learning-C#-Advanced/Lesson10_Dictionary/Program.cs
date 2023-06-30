using System;
using System.Collections.Generic;
namespace DictionaryCS
{
    class Program{
        static void Main(string[] args) {
            /*
            Khởi tạo 1 dictionary rỗng với key value là kiểu string 
            */
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            /*
            Khởi tạo 1 dictionary rỗng với key value là kiểu string 
            chỉ định capacity là 5
            */
            Dictionary<string, string> dictionary2 = new Dictionary<string, string>(5);
            /*
            Khởi tạo 1 dictionary có kích thước bằng dictionary2
            sao chép toàn bộ phần tử trong dictionary2 vào dictionary3
            */
            Dictionary<string,string> dictionary3 = new Dictionary<string,string>(dictionary2);


        }
    }
}

/*
?Dictionary là gì
Tương tự như list, thay thế cho hashtable
Vì là thay thế cho hashtable nên cách sử dụng cũng tương tự hashtable 
Lưu trữ dữ liệu dưới dạng cặp key value. 
Truy xuất dữ liệu bằng Key 


?Một số phương thức thuộc tính
!Một số thuộc tính thông dụng 
_____________________________________________________________________________________
|       Tên thuộc tính   |  Mô tả                                                   |
|________________________|__________________________________________________________|
|       Count            | Trả về số nguyên là phần tử hiện có trong Dictionary     |
|________________________|__________________________________________________________|
|       Key              |  Trả về danh sách chứa các key trong Dictionary          |
|________________________|__________________________________________________________|
|       Value            |  Trả về danh sách chứa value trong Dictionary            |
|________________________|__________________________________________________________|
!Một số phương thức thông dụng 
_______________________________________________________________________________________
|           Tên phương thức         |           Tên Thuộc Tính                        |
|___________________________________|_________________________________________________|
|   Add(TKey Key,TKey Value)        |   Thêm 1 cặp Key-Value vào Dictionary           |
|___________________________________|_________________________________________________|
|               Clear()             |   Xóa tất cả các phần tử trong Dictionary       |
|___________________________________|_________________________________________________|
|   ConstainKey(TKey Key)           |   Kiểm tra đối tượng key có tồn tại trong       |
|                                   |   Dictionary hay không                          |
|___________________________________|_________________________________________________|
|   ConstainValue(TKey Value)       |   Kiểm tra đối tượng Value có tồn tại trong     |
|                                   |   Dictionary hay không                          |       
|___________________________________|_________________________________________________|
|       Remove(TKey Key)            |   Xóa đối tượng có Key xuất hiện đầu tiên trong |
|                                   |   Dictionary                                    |
|___________________________________|_________________________________________________|
|TryGetValue(TKey Key,TValue Value) |   Kiểm tra Key có tồn tại hay không, nếu có trả |
|                                   |   về true đồng thời trả lại value tương ứng qua |                        
|                                   |   biến Value, ngược lại trả về false            |
|___________________________________|_________________________________________________|

!Một số lưu ý
Mỗi một phần tử trong Dictionary (bao gồm 1 cặp Key - Value) được C# định nghĩa là 1 đối tượng
có kiểu KeyValuePair<TKey,TValue>. Trong KeyValue<Tkey,TValue> có 2 thuộc tính chính:
    *Key: trả về giá trị key của phần tử hiện tại
    *Value: trả về giá trị value của phần tử hiện tại

Điều này tương tự như DictionaryEntry trong hashtable. Vì thế cách sử dụng cũng tương tự.

!Một số sự khác biệt giữa Dictionary và HashTable
_____________________________________________________________________________________________
|                   HashTable                 |                 Dictionary                  |      
|_____________________________________________|_____________________________________________|
|   ThreadSafe-Hỗ trợ multithread không đụng  |                 Không hỗ trợ                |
|               độ tài nguyên                 |                                             |
|_____________________________________________|_____________________________________________|
|   Cặp Key-Value lưu kiểu Object             | Phải xác định cụ thể kiểu dữ liệu của cặp   |
|                                             |                     Key-Value               |
|_____________________________________________|_____________________________________________|
|   Truy xuất phần tử không tồn tại trong     |     Truy xuất phần tử không tồn tại trong   |
|   HashTable sẽ không bao lỗi => Return NULL |             Dictionary sẽ báo lỗi           |
|_____________________________________________|_____________________________________________|
|            Hiệu quả cho dữ liệu lớn         |         Không hiệu quả cho dữ liệu lớn      |
|_____________________________________________|_____________________________________________|
|   Các phần tử được sắp xếp lại mỗi khi thêm | Các phần tử nằm theo thứ tự được thêm vào   |
|   hoặc xóa các phần tử trong HashTable      |                                             |
|_____________________________________________|_____________________________________________|
|              Tìm kiếm nhanh hơn             |                Tìm kiếm chậm hơn            |
|_____________________________________________|_____________________________________________|

*/
