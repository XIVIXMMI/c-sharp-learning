using System;
using System.Collections;
namespace StackCsharp
{
    class Program{
        static void Main(string[]agrs){
            #region Initialize a new Stack
            // Stack firstStack = new Stack();
            // Stack secondStack = new Stack(5);//capacity = 5
            // ArrayList myArr = new ArrayList();//Initialize a new array
            // myArr.Add(5);
            // myArr.Add(6);
            // myArr.Add(7);
            // Stack thirdStack = new Stack(myArr);
            #endregion
            #region Sử dụng stack 
            //Tạo 1 stack rỗng
            Stack<string> stack = new Stack<string>();

            //Thực hiện thêm vài phần tử vào Stack thông qua hàm Push
            stack.Push("Jocelyn");
            stack.Push("Billy");
            stack.Push("JoJo");

            //Thử sử dụng phương thức của stack
            Console.WriteLine("Number of current elements: {0}",stack.Count);

            //Dùng peek để xem giá trị mà không xóa phần tử ra khỏi stack 
            Console.WriteLine("The top elements in stack is: {0}",stack.Peek());

            //Thử kiểm tra lại số phần tử để chắc chắn peek không xóa phần tử ra khỏi stack 
            Console.WriteLine("Number of current elements: {0}",stack.Count);

            //Thực hiện xóa phần tử ra khỏi stack bằng pop
            Console.WriteLine("Popping...");
            int Length = stack.Count;
            for (int i = 0; i < Length;i++){
                Console.WriteLine( " " +stack.Pop());
            }
            Console.WriteLine("After Pop!"); 
            //Kiểm tra lại số phần tử sau khi pop
            Console.WriteLine("Number of current elements: {0}",stack.Count);
            #endregion
        }
    }
}
/*
?Stack là gì
    Stack (hay còn gọi là ngăn xếp) 1 cấu trúc dữ liệu hoạt động theo nguyên lý LIFO(Last in first Out)
    Người ta hay gọi nó là ngăn xếp bởi vì nó hoạt động giống như một ngăn xếp trong thực tế.

!Đặc điểm của Stack 
    *Là danh sách lưu trữ các đối tượng nhưng không thể truy cập các phần tử thông qua index
    *Hành động thêm phần tử vào stack được gọi là push
    *Hành động lấy phần tử ra khỏi stack được gọi là pop và luôn luôn lấy ra phần tử được thêm vào cuối cùng
=>Stack cũng là 1 collection 

?Một số phương thức và thuộc tính hỗ trợ sẵn trong stack

Peek():Trả lại giá trị của phần tử nằm ở vị trí trên cùng của Stack
(phần tử được thêm vào cuối cùng nhưng không bị xóa khỏi stack ): chỉ xem không lấy phần tử ra khỏi stack 
Pop(): trả lại giá trị của đối tượng nằm ở vị trí trên cùng 
(Phần tử được thêm và cuối cùng và bị xóa khỏi stack): nghĩa là lấy phần tử ra khỏi stack 
Push(object Value): thêm phần tử có giá trị Value vào vị trí trên cùng trong stack
*/