using System;
using System.Collections;
using SL;
namespace SL
{
    class Program{
        static void Main(string[]agrs){
            #region 
            // SortedList mySL = new SortedList();
            // SortedList mySL2 = new SortedList(5);//Khởi tạo sortedlist với capacity = 5
            // SortedList mySL3 = new SortedList(mySL2);
            // /*
            // Định nghĩa 1 lớp PersonComparer có thực thi 1 interface IComparer
            // Sau đó override lại phương thức Compare.
            // Sử dụng lớp trên để truyền vào constructor của SortedList.
            // */
            // SortedList mySL4 = new SortedList(new PersonComparer());
            // /*
            // Tạo 1 SortedList mới và sao chép các phần tử từ mySL3 đồng thời sắp xếp các phần tử còn lại
            // theo cách sắp xếp được định nghĩa trong lớp PersonComparer 
            // */
            #endregion
            #region 
            SortedList mySL6 = new SortedList(new PersonComparer());
            mySL6.Add(new Person("Nguyen",22),10);
            mySL6.Add(new Person("Billy",30),15);
            mySL6.Add(new Person("Owl",5),2);
            foreach(DictionaryEntry item in mySL6){
                Console.WriteLine("Key: "+item.Key + " - Value: " + item.Value);
            }
            #endregion
        }
    }
    class PersonComparer : IComparer
    {
        public int Compare(object? x, object? y){
            Person? a = x as Person;
            Person? b = y as Person;
            if ( a == null || b == null){
                throw new InvalidOperationException();
            }else{
                if(a.Age > b.Age){
                    return 1;
                }else if(a.Age == b.Age){
                    return 0;
                }else{
                    return -1;
                }
            }
        }
    }
}

/*
Là 1 collection lưu trữ dữ liệu dưới dạng cặp key - value
Đặc điểm của sortedlist là giống với hashtable nhưng các giá trị được sắp xếp theo Key
Việc sắp được thực hiên 1 cách tự động khi thêm phần tử vào sotedlist 
Có thể truy cập đến phần tử thông qua Key như hashtable hoặc index như ArrayList 
*=>SortedList là sự kết hợp giữa Hashtable và ArrayList 
Do sortedlist cũng là 1 collection nên khi sử dụng cần thêm system.collection
trước khi sử dụng cần khởi tạo vùng nhớ mới bằng toán tử new 
?Phương thức và thuộc tính
Do SortedList là sự kết hợp của Array List và Hashtable nên nó mang hầu hết các phương thức và thuộc tính của lớp đó

GetByIndex(int Index):Trả về giá trị Value tại tại vị trí Index trong SortedList
GetKeyList():Trả về 1 list các Key trong sortedlist 
GetValueList():Trả về 1 list các Value trong sortedlist

!Lưu Ý:
Nếu muốn các key là đối tượng thuộc các 1 lớp nào đó thì cần phải định nghĩa kiểu so sánh cho đối tượng đó
Nếu không chương trình sẽ báo lỗi vì không biết sẽ sắp xếp như thế nào
Nói dễ hiểu hơn thì nếu là kiểu dữ liệu cho ta định nghĩa thì cần phải định nghĩa luôn cả cách sắp xếp 

*/
