using System;
using System.Collections;
namespace BitArray
{
    class Program{
        public static void PrintBits(BitArray myBA,int Width){
            int i = Width;
            foreach(bool item in myBA){
                if(i < Width){
                    i = Width;
                    Console.WriteLine();
                }
                i--;
                Console.Width(item.GetHashCode());// in ra 1 0 thay vi true false
            }
            Console.WriteLine("");
        }
        static void Main(string[] args){
            /*
            Khởi tạo 1 BitArray có 10 phần tử.
            mỗi phần tử có giá trị mặc định là 0 (false)
            */
            BitArray myBA = new BitArray(10,false);
            /*
            Khởi tạo 1 BitArray có 10 phần tử.
            mỗi phần tử có giá trị mặc định là 1 (true)
            */
            BitArray myBA2 = new BitArray(10,true);
            /*
            Khởi tạo 1 BitArray từ một mảng bool 
            */
            bool[] myBools = new bool[5]{true,false,true,true,false};
            BitArray myBA3 = new BitArray(myBools);
            /*
            Khởi tạo 1 BitArray từ 1 mảng byte có sẵn
            */
            byte[]  myByte = new byte[5]{1,2,3,4,5};
            /*
            Kiểm thử
            */
            Console.WriteLine("The number of BitArray is {0}",myByte);
            PrintBits(myByte, 8);


            Console.WriteLine("");
        }
    }
}

/*
?BitArray là gì 
Là 1 collection lưu trữ 1 danh sách các bit 0 1 được biểu diễn như kiểu boolean (true = 1 ; false = 0)
Nó được sử dụng khi ta cần lưu trữ danh sách bit mà chưa biết số lượng 
ta có thể truy cập các phần tử trong BitArray giống bằng chỉ số giống như ArrayList 
?Vậy tại sao không dùng mảng kiểu bool mà lại dùng BitArray
*=> bởi vì BitArray giúp tiết kiệm bộ nhớ hơn rất nhiều
    *Mặc dù kiểu bool chỉ lưu 2 giá trị true false nhưng lại tốn 1 bytes cho mỗi biến kiểu bool
    *Trong khi đó mỗi 1 phần tử trong BitArray chỉ tốn 1 bit để lưu trữ
Trước khi sử dụng cần khởi tạo bằng toán tử new và lưu ý là không thể khởi tạo 1 BitArray rỗng
?Một số phương thức và thuộc tính 
And(BitArray Value): thực hiện toán tử AND bit giữa dãy bit hiện tại và dãy bit Value trả về BitArray là kết quả của phép toán trên
Not(): trả về 1 BitArray là kết quả của phép toán NOT trên dãy bit hiện tại
Or(BitArray Value): Trả về 1 BitArray là kết quả của phép toán OR giữa dãy bit hiện tại và dãy bit Value
Xor(BitArray Value): Trả về 1 BitArray là kết quả của phép toán XOR giữa dãy bit hiện tại và dãy bit Value
!Các phép toán AND OR XOR NOT phải được thực hiện trên BitArray cùng độ dài nếu không sẽ báo lỗi
!Các phép toán AND OR XOR NOT sẽ làm thay đổi cả BitArray gọi nó, ví dụ

BitArray A = new BitArray(5);
BitArray B = new BitArray(5,true);
A.And(B);
Thì kết quả sẽ được cập nhật vào A



*/
