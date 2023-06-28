using System;
using System.Collections;
namespace HashTable
{
    class Program{
        static void Main(string[]agrs){
            #region initialize a new Hashtable
            // Hashtable myHash = new Hashtable(); //initialize a new hashtable
            // Hashtable myHash2 = new Hashtable(5); //initialize a new hashtable with initial capacity of 5
            // myHash2.Add("001","Nguyen Van A");
            // myHash2.Add("002","Nguyen Van B");
            // /*
            // Initializ a new hastable with a size equal to myHash2
            // Copy all the elements from myHash2 to myHash3
            // */
            // Hashtable myHash3 = new Hashtable(myHash2);
            #endregion
            #region some point to note in Hashtable
            //create a new simply hashtable with 3 element
            Hashtable hash = new Hashtable();
            hash.Add("Na","Natri");
            hash.Add("H2","Hidro");
            hash.Add("O2","Oxigen");
            /*
            browse all the element in hashtable
            because every element is a DictionaryEntry so we need to define datatype for item is DictionaryEntry
            let's print all the key - value of every element after browse
            */
            // foreach(DictionaryEntry item in hash){
            //     Console.WriteLine(item.Key + "\t" +item.Value);
            // }
            //let's print a value in Key does not exist
            Console.WriteLine("Hash[\"VT\"]="+hash["VT"]);
            //To make sure the Key is null we will use if
            // if(hash["VT"]==null){
            //     Console.WriteLine("Key 'VT' is not exist");
            // }
            //let's print the number of current elements in hashtable
            Console.WriteLine("\nCount: "+ hash.Count);
            foreach(DictionaryEntry item in hash){
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
            //assign value for a key does not exist
            hash["Cl"]="Clo";
            //lets print the number of current value again to see the change
            Console.WriteLine("\nCount: " + hash.Count);
            foreach(DictionaryEntry item in hash){
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
            #endregion
        }
    }
}

/*
?HashTable là gì?
Là 1 collection lưu trữ dữ liệu dưới dạng key - value.
Do sử dụng key - value nên chỉ có thể sử dụng Key không thể sử dụng index
Key và Value đều là kiểu Object nên ta có thể lưu trữ mọi kiểu dữ liệu
Do HashTable là một lớp nên khi muốn sử dụng cần phải khởi tạo vùng nhớ mới bằng toán tử new
?Một số thuộc tính của HashTable
!Một số thuộc tính thông dụng 
_____________________________________________________________________________________
|       Tên thuộc tính   |  Mô tả                                                   |
|________________________|__________________________________________________________|
|       Count            | Trả về số nguyên là phần tử hiện có trong Hashtable      |
|________________________|__________________________________________________________|
|       Key              |  Trả về danh sách chứa các key trong hashtable           |
|________________________|__________________________________________________________|
|       Value            |  Trả về danh sách chứa value trong hashtable             |
|________________________|__________________________________________________________|
!Một số phương thức thông dụng 
_______________________________________________________________________________________
|           Tên phương thức         |           Tên Thuộc Tính                        |
|___________________________________|_________________________________________________|
|   Add(object Key,object Value)    |   Thêm 1 cặp Key-Value vào Hashtable            |
|___________________________________|_________________________________________________|
|               Clear()             |   Xóa tất cả các phần tử trong Hashtable        |
|___________________________________|_________________________________________________|
|               Clone()             |   Tạo 1 bản sao từ Hashtable hiện tại           |
|___________________________________|_________________________________________________|
|   ConstainKey(object Key)         |   Kiểm tra đối tượng key có tồn tại trong       |
|                                   |   Hashtable hay không                           |
|___________________________________|_________________________________________________|
|   ConstainValue(object Value)     |   Kiểm tra đối tượng Value có tồn tại trong     |
|                                   |   Hashtable hay không                           |
|___________________________________|_________________________________________________|
|                                   |   Thực hiện sao chép tất cả phần tử trong       |
|                                   |   Hashtable sang mảng 1 chiều arr từ vị trí     |
|   CopyTo(Array arr, int Index)    |   Index của arr, lưu ý arr phải là mảng các     | 
|                                   |   object hoặc mảng các DictionaryEntry          |
|___________________________________|_________________________________________________|
|       Remove(object Key)          |   Xóa đối tượng có Key xuất hiện đầu tiên trong |
|                                   |   Hashtable                                     |
|___________________________________|_________________________________________________|

TODO: Hashtable rất nhanh, và để làm được điều đó khi thêm phần tử mới vào nó sẽ tự sắp xếp lại 
TODO: Để khi chúng ta truy xuất sẽ có tốc độ truy xuất nhanh.
TODO: Nếu muốn lấy giá trị value thông qua key mà key  không tồn tại sẽ mặc định là null và không báo lỗi
TODO: Nếu thực hiện gán gía trị cho 1 phần tử trong Hasbtable tại vị trí Key không tồn tại
TODO: thì hashtable sẽ tự thêm 1 phần tử mới với key và value như trên, điều này có thể phát sinh những phần tử không mong muốn trong danh sách

*/
