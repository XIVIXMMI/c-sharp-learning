using System;
using System.Threading;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ví dụ 1
            // DemoThread();
            // DemoThread();
            // DemoThread();
            #endregion

            #region Ví dụ 2
            /* 
            Tạo một Thread t với anonymous function và gọi hàm DemoThread bên trong
            Thread chỉ bắt đầu chạy khi gọi hàm Start
            Bạn có thể thực hiện một hàm hay nhiều dòng code ở bên trong anonymous function này
             */
            // Thread t = new Thread(()=> {
            //     DemoThread2("Thread 1");
            // });
            // t.Start();
            
            // Thread t2 = new Thread(() => {
            //     DemoThread2("Thread 2");
            // });
            // t2.Start();

            // Thread t3 = new Thread(() => {
            //     DemoThread2("Thread 3");
            // });
            // t3.Start();
            #endregion

            #region Ví dụ 3
            for (int i = 0; i < 5; i++)
            {
                int tempI = i;
                Thread t = new Thread(() => {
                    DemoThread2("Thread " + tempI);
                });
                t.Start();
            }
            Console.ReadLine();
            #endregion
        }
        static void DemoThread()
        {
            // Thực hiện vòng lặp 5 lần. Mỗi lần tốn 1 giây
            for (int i = 0; i < 5; i++)
            {
                // Làm gì đó tốn 1s. Dùng Thread.Sleep để luồng hiện tại ngủ theo thời gian được cài đặt.
                // Mục đích để giả lập độ trễ của code xử lý
                Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.WriteLine(i);
            }
        }
        static void DemoThread2(string threadIndex)
        {
            // Thực hiện vòng lặp 5 lần. Mỗi lần tốn 1 giây
            for (int i = 0; i < 5; i++)
            {
                // Làm gì đó tốn 1s. Dùng Thread.Sleep để luồng hiện tại ngủ theo thời gian được cài đặt.
                // Mục đích để giả lập độ trễ của code xử lý
                Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.WriteLine(threadIndex + " - " + i);
            }
        }
    }
}
/*
?Multi threading là gì? Vì sao cần Multi threading.
Multithreading có thể hiểu là 1 kỹ thuật dùng để xử lý đa tác vụ
Bản chất của chương trình C# gồm có 2 luồng chính là MainThread luồng mặc định hàm main và UIThread để cập nhật giao diện
Các code mà chúng ta viết nằm trong Mainthread
Chương trình sẽ chạy tuần tự các hàm từ trên xuống dưới, từ hàm này đến hàm khác
Nên khi cần xử lý 3 hàm cùng lúc thì không thể được 
Do đó => MultiThreading ra đời 
=> Trong C# chúng ta có thể dùng thread để thực hiện đa luồng
(Không chỉ còn 2 luồng cơ bản mà còn có thể tạo ra n luồng chạy song song với nhau)
?Cách dùng Thread trong C#
Class Thread nằm trong thư viện System.Threading của .Net. 
Để có thể sử dụng Thread thì chúng ta sẽ using System.Threading.
Chúng ta tạo một hàm DemoThread với mục đích là giả lập lại một hàm xử lý mất thời gian 5 giây. 
Ở đây mình dùng Thread.Sleep để mô phỏng lại việc sẽ tiêu tốn một giây cho mỗi lần lặp xử lý với 5 lần lặp. 
Thread.Sleep có nhiệm vụ làm cho luồng hiện tại ngủ theo thời gian được cài đặt.

Kết quả có thể thấy màn hình Console sẽ in ra giá trị của I sau mỗi 1 giây. Sau 5 giây thì hoàn thành. 
Vậy nếu chúng ta gọi 3 hàm DemoThread này liên tục sẽ tiêu tốn 15s để hoàn thành chương trình.

Bây giờ chúng ta sẽ cho mỗi hàm demo vào một luồng riêng biệt để thực hiện. 
Lúc này tốc độ sẽ tăng lên đáng kể vì 3 luồng chạy song song nhau. 
Chúng ta dùng cách tạo và gọi Thread và sử dụng tối ưu nhất để bạn dễ tiếp cận. 
Bạn có thể tìm hiểu thêm về ThreadStart nếu muốn.
Vì muốn biết giá trị của i được in ra từ hàm nào nên mình truyền thêm tham số cho hàm DemoThread và in kèm giá trị đó.

*Thread chỉ bắt đầu chạy khi bạn gọi hàm Start.
?Cách dùng multi Thread trong C#

?Các lưu ý khi dùng Thread trong C#
Nếu Thread của bạn xử lý nhiều hoặc lặp vô tận. 
Bạn nên set thuộc tính IsBackground cho Thread là true để khi chương trình của bạn tắt, Thread của bạn cũng sẽ được giải phóng. 
Còn nếu IsBackground = false. Thì chương trình của bạn phải đợi Thread này chạy xong thì mới có thể kết thúc.
*Syntax: t.IsBackground = true;
Nếu bạn code MultiThreading ở các ngôn ngữ khác như Winform hay WPF 
thì nên đưa code xử lý liên quan đến giao diện vào trong Invoke để tránh đụng độ tài nguyên khi sử dụng.
(cấu trúc Invoke có thể khác một chút tùy vào ngôn ngữ bạn dùng).
*Syntax: 
    *Invoke trong Winform
    *Invoke cần một đối tượng giao diện để Invoke. Ở đây mình dùng this là form hiện tại.
    *Bạn có thể dùng control bất kỳ thay thế
    this.Invoke(new Action(()=> {
        *code của bạn
    }));

    *Invoke trong WPF
    *Invoke cần một đối tượng giao diện để Invoke. 
    *Ở đây mình dùng this là Window hiện tại.
    *Bạn có thể dùng control bất kỳ thay thế
    *WPF cần Dispathcer để Invoke
    this.Dispatcher.Invoke(new Action(()=> {
        *code của bạn
    }));


*/
