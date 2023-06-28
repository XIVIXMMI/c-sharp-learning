using System;
using System.Collections;
using System.Collections.Generic;

namespace QueueCsharp
{
    class Program{
        static void Main(string[] args){
            #region Khai báo và khởi tạo Queue
            Queue myQueue = new Queue();    
            Queue secondQueue = new Queue(5);    

            ArrayList arrayList= new ArrayList();
            arrayList.Add(5);
            arrayList.Add(6);
            arrayList.Add(7);

            Queue thirdQueue = new Queue(arrayList);
            #endregion
            
            Queue queue = new Queue();

            queue.Enqueue("Billy");
            queue.Enqueue("Jocelyn");
            queue.Enqueue("Takumi");

            Console.WriteLine("The number of current element: {0}",queue.Count);

            Console.WriteLine("Implement Peek method: {0}",queue.Peek());

            Console.WriteLine("The number of current element: {0}",queue.Count);

            Console.WriteLine("Implement Dequeue method...");
            int Length = queue.Count;
            for (int i = 0; i < Length;i++){
                Console.WriteLine("{0}",queue.Dequeue());
            }
            Console.WriteLine("After Dequeue: {0}",queue.Count);
            Console.WriteLine("");
        }
    }
}

/*
?Queue là gì 
Queue hay còn gọi là hàng đợi, hoạt động theo nguyên lý FIFO 
!Đặc điểm của Queue
*là một danh sách lưu trữ các đối tượng nhưng không thể truy cập bằng index 
*Hành động thêm phần tử vào Queue gọi là Enqueue (xếp hàng)
*Hành động lấy phần tử ra khỏi Queue gọi là Dequeue (ra khỏi hàng) 
*và luôn lấy phần tử được thêm vào đầu tiên 

=> Queue rất giống Stack chỉ khác ở nguyên lý hoạt động nên Stack có gì Queue sẽ có cái tương tự
=> Queue cũng là 1 collection 
?Một số phương thức và thuộc tính
Dequeue(): trả về giá trị của đối tượng tại vị trí đầu tiên trong Queue(phần tử được thêm đầu tiên) đồng thời xóa ra khỏi Queue
Enqueue(object Value): Thêm 1 phần tử có giá trị Value vào đầu Queue
Peek(): trả về giá trị của đối tượng tại vị trí đầu tiên trong Queue nhưng không xóa nó ra khỏi Queue

*/
