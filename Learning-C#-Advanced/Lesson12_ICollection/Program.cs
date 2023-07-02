using System;
using System.Collections;
using System.Collections.Generic;
namespace ICollectionCS
{
    class Program
    {
        public void Sort(IComparer comparer)
        {
            int count = Array.Count;
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (comparer.Compare(Array[i], Array[j]) > 0)
                    {
                        object temp = Array[i];
                        Array[i] = Array[j];
                        Array[j] = temp;
                    }
                }
            }
        }
        public class MyArrayList : ICollection
        {
            /*
            Tạo 1 lớp MyArrayList thực thi interface ICollection
            */
            private object[] lstObj; //mang gia tri
            private int count; //số lượng phần tử 
            private const int MaxCount = 100;
            public MyArrayList()
            {
                count = -1;
                /*
                -1 ở đây được thể hiện như 1 quy ước ngầm
                có thể hiểu -1 ở đây là NULL
                chưa từng có 1 giá trị nào cả 
                */
                lstObj = new object[MaxCount];
            }
            public MyArrayList(int count)
            {
                this.count = count;
                lstObj = new object[count];
            }
            public MyArrayList(Array array)
            {
                array.CopyTo(lstObj, 0);
                count = array.Length;
            }
            public void CopyTo(Array array, int index)
            {
                //thực hiện copy các phần tử trong lstObj từ vị trí index đến cuối sang mảng array
                lstObj.CopyTo(array, index);
            }
            public int Count
            {
                get { return count; }
            }
            public bool IsSynchronized
            {
                get { throw new NotImplementedException(); } //chưa được định nghĩa 
            }
            public object SyncRoot
            {
                get { throw new NotImplementedException(); }
            }
            public IEnumerator GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("");
        }
    }

}
/*
?ICollection là 1 interface được định nghĩa sẵn trong bộ interface của dotnet framework 
?Tại sao dotnet lại định nghĩa sẵn nhiều interface 
*Đưa ra chuẩn mực chung, mỗi interface đại diện cho tính chất nào đó 
*Khi muốn cấu trúc dữ liệu của mình có tính chất nào đó chỉ cần thực thi đúng interface được định nghĩa sẵn
*Việc định nghĩa sẵn Interface cũng là 1 cách để giúp Dev có thể tùy chỉnh 1 số chức năng bên trong .NET framework
?Phương thức và thuộc tính:
Count : trả về số lượng phần tử của tập hợp 
IsSynchronized và SyncRoot: 2 property để làm cho thao tác đa luồng và tập hợp an toàn hơn
CopyTo(Array array , int Index): phương thức dùng để copy tập hợp ra 1 mảng bắt đầu từ vị trí index
GetENumerator(): trả về đối tương thuộc kiểu IEnumerator

TODO: ICollection là 1 interface có ý nghĩa "xác định kích thước, enumerator(bộ liệt kê) và những phương thức đồng bộ cho những tập hợp không phải kiểu generic" 
TODO: Hay nói ngắn gọn hơn đây là 1 interface thể hiện tính chất của 1 Collection 
*/
