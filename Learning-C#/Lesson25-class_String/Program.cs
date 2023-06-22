using System;
namespace program
{
    class program{
        static void Main(string[] args){
            /*  Khai báo 1 biến kiểu chuối fullName
                Khai báo 1 biến Result chứa kết quả chuẩn hóa chuỗi
                Giá trị biến fullName nhập từ bàn phím
            */
            string fullName;
            string Result = "";
            Console.Write("Please enter your full name: ");
            fullName = Console.ReadLine();
            /*  Cắt các khoảng trống dư ở đầu và cuối chuỗi */
            fullName = fullName.Trim();
            /* Trong khi còn tìm thây 2 khoảng trắng
            thì thực hiện thay thế 2 khoảng trắng bằng 1 khoảng trắng*/
            while(fullName.IndexOf("  ") != -1){
                fullName = fullName.Replace("  "," ");
            }
            /* Cắt chuỗi họ tên ra thành mảng các phần tử.
            Sau đó duyệt mảng để chuẩn hóa từng từ một
            Khi duyệt mỗi từ ta thực hiện cắt ra chữ cái đầu tiên trên và lưu trong biến firstChar
            Cắt các chữ cái còn lại và lưu trong biến otherChar
            thực hiện viết hóa chữ cái đầu và viết thường các chữ cái còn lại.
            cuối cùng là lưu chữ vừa chuẩn hóa vào biến Result*/
            string[] subName = fullName.Split(' ');
            for(int i = 0; i <subName.Length; i++ ){
                string firstChar = subName[i].Substring(0,1);
                string otherChar = subName[i].Substring(1);
                subName[i] = firstChar.ToUpper() + otherChar.ToLower();
                Result += subName[i] + " ";
            }
            Console.WriteLine("Your full name is: "+ Result);
            
        }
    }
}
/*  Lớp String trong C# 
    => là một kiểu dữ liệu tham chiếu được dùng để lưu trữ chuỗi ký tự
        vì là 1 kiểu dữ liệu nên việc khai báo và sử dụng hoàn toàn như kiểu dữ liệu khác 
    Ứng dụng lớp String trong xử lý chuỗi 
    + Một số phương thức thường dùng trong lớp String
    - String.Compare(string StrA, string StrB): 
        So sánh 2 chuỗi StrA và StrB có bằng nhau hay không, nếu bằng thì trả về 0
        Nếu StrA > StrB thì trả về 1 và StrA < StrB thì trả về -1.
    <tên biến>.CompareTO(string StrB)
    - String.Concat(string StrA, string StrB): 
        Nối 2 chuỗi StrA và StrB thành 1 chuỗi, tương tự như cộng chuỗi bằng toán tử cộng.
    - IndexOf(char value)): Trả về một số nguyên kiểu int là vị trí xuất hiện đàu tiên của ký tự value trong chuỗi,
        nếu như không tìm thấy thì trả về -1.
    - Insert(int startIndex, string value):
        Trả về một chuỗi mới trong đó bao gồm chuỗi cũ đã chèn thêm chuỗi "value" tại vị trí startIndex.
    - String.IsNullOrEmpty(string value):
        Kiểm trả chuỗi value có phải chuỗi null hoặc rỗng hay không. Nếu đúng thì trả về true, ngược lại là false.
    - LastIndexOf(char value):
        Trả về một số nguyên kiểu int là vị trí xuất hiện cuối cùng của ký tự value trong chuỗi.
        ( chẳng hạn trong chuỗi có 2 chữ K thì IndexOf trả về chữ K đầu tiên còn LastIndexOf trả về chữ K cuối cùng)
    - Remove(int startIndex, int count):
        Trả về mỗ chuỗi mới đã gỡ bỏ count ký tự từ vị trí startIndex trong chuỗi ban đầu
    - Replace(char oldValue, char newValue):
        Trả về một chuỗi mới đã được thay thế các ký tự oldValue bằng ký tự newValue trong chuỗi ban đầu.
    - Split(char value): 
        Trả về một mảng các chuỗi được cắt ra từ chuỗi ban đầu tại những nơi có ký tự value, có thể truyền nhiều ký tự
        khi đó phương thức sẽ cắt theo từng ký tự được truyền vào.
    - Substring(int startIndex, int length): 
        Trả về một chuỗi mới được cắt từ vị trí startIndex với số ký tự cắt là length từ chuỗi ban đầu.
        Nếu như gọi hàm Substring mà chỉ truyền vào giá trị startIndex thì mặc định phương thúc sẽ cắt từ vị trí startIndex đến cuối chuỗi
    - ToCharArray(): trả về một mảng các ký tự trong chuỗi ban đầu .
    - ToLower(): trả về một chuỗi mới đã đươc viết thường các ký tự trong chuỗi ban đầu.

    Lưu Ý:  Các phương thức có String. nghĩa là phải thông qua tên lớp
            Các phương thức được gọi sẽ tạo ra đối tượng mới rồi thao tác trên đối tượng đó
            chứ không thao tác trực tiếp trên đối tượng đang xét.
            + Vì thế: 
            string a = "Hello World";
            a.Substring(3,1);

            Thì biến a sau khi thực hiện Substring vẫn mang giá trị là "Hello World"
            nếu muốn biến a mang giá trị mới sau khi Substring thì phải gán giá trị ngược lại cho biến a

            a = a.Substring(3,1);


    Lớp String builder trong C#
    Đặc điểm là lớp String Builder trong .NET được xây dựng sẵn
    để chúng ta tương tác trực tiếp với chuỗi gốc giúp tiết kiệm bộ nhớ hơn
    Đặc điểm:
    - Thao tác trực tiếp với chuỗi ban đầu
    - Tự mở rộng vùng nhớ khi cần
    - Không cho lớp khác kế thừa
    => Ít tốn bộ nhớ hơn String 

    Ví dụ: 
    string Value = "Hello";
    Value = Value + "World"
    Ở 2 dòng lệnh trên ta có thể thấy bộ nhớ được lưua như sau:
    + Đầu tiên tạo 1 vùng nhớ cho đối tượng kiểu string tên là Value.
    + Tạo 1 vùng nhớ chứa giá trị "Hello"
    + Khi thực hiện toán tử cộng trên 2 chuỗi sẽ tạo ra 1 vùng nhớ nữa để chứa giá trị chuỗi mới sau khi cộng
    + Cuối cùng phép gán sẽ thực hiện trỏ đối tượng Value sang vùng nhớ chứa chuỗi kết quá của phép cộng.
    => Như vậy sẽ có 1 vùng nhớ không sử dụng còn nằm trong bị nhớ
    đó là vùng nhớ chứa giá trị "Hello" - giá trị ban đầu của biến Value

    Đối với StringBuilder thì khác: 
    
    StringBuilder MutableValue = new StringBuilder("Hello");
    MutableValue.Append("World");
    Ở 2 câu lệnh trên bộ nhớ sẽ lưu trữ như sau:
    + Tạo 1 vùng nhớ cho đối tượng MutableValue chứa giá trị "Hello".
    + Tạo 1 vùng nhớ chứa giá trị "World".
    + Mở rộng vùng nhớ của MutableValue để nối chuỗi "World" vào sau chuỗi "Hello".

    => không cần tạo quá nhiều vùng nhớ và cũng không lãng phí bất kì vùng nhớ nào.

    Sử dụng: 
        - Khởi tạo 1 đối tượng rỗng:
        StringBuilder <tên biến> = new StringBuilder();
        - Khởi tạo 1 đối tượng chứa 1 chuỗi cho trước:
        StringBuilder <tên biến> = new StringBuilder(<chuỗi giá trị>);

    Các phương thức: 
    + Append(string Value): Nối chuỗi Value vào sau chuỗi ban đầu(giống toán tử cộng)
    + Clear() Xóa bỏ toàn bộ nội dung trong đối tượng (lưu ý không phải xóa vùng nhớ của đối tượng)
    + ToString() Chuyển đối tượng kiểu StringBuilder sang kiểu String
*/

