namespace Polymorphisim
{
    abstract class Animal{
    //     public virtual void Speak()
        // {
        //     Console.WriteLine("Animal is speaking...");
        // }
        /*
        Khai báo thức thuần nên không cần định nghĩa nội dung phương thức 
        */
        public abstract void Speak();
    }
    class Cow : Animal{
        public override void Speak()
        {
            Console.WriteLine("Cow is mooing...");
        }
    }
    class Cat : Animal{
        public override void Speak()
        {
            Console.WriteLine("Cat is mewing...");
        }
    }
    class Fox : Animal {
        public override void Speak()
        {
            Console.WriteLine("What does the fox say ?");
        }
    }
    /*
    Ta thấy 3 đối tượng cow,cat,fox được cấp 3 vùng nhớ thuộc 3 lớp khác nhau
    nhưng khi cùng gọi phương thức Speak() thì đối tượng tham chiếu đến vùng nhớ của lớp nào
    sẽ được được gọi đúng phương thức của lớp đó.
    */
    class Program{
        static void Main(string[]agrs){
            Animal cow = new Cow();
            Animal cat = new Cat();
            Animal fox = new Fox();

            cow.Speak();
            cat.Speak();
            fox.Speak();
        }
    }
}
/*
?Khái niệm về tính đa hình 
Tính đa hình là hiện tượng các đối tượng thuộc lớp khác nhau có thể hiểu 1 thông điệp theo những cách khác nhau
*Ví dụ về đa hình trong thực tế
Ta có 3 con vật là chó, mèo, lợn. Chúng đều là động vật như khi ta bảo chúng thực hiện hành động kêu thì chúng lại kêu theo cách khác nhau
Ở ví dụ này ta xem 3 con vật là đối tượng, việc chúng ta bảo chúng kêu là thông điệp.
Rõ ràng việc chúng có thể hiểu thông điệp và kêu theo cách khác nhau.
!Để thực hiện được đa hình trong lập trình
*các lớp phải có quan hệ kế thừa với cùng 1 lớp cha
*phương thức đa hình phải được ghi đè (override) ở các lớp con 
?Từ khóa virtual và từ khóa override
*Virtual là từ khóa dùng để khai báo phương thức ảo (Phương thức ảo là phương thức có thể ghi đè lên được)
*Override là từ khóa dùng để đánh dấu phương thức ghi đè lên phương thức của lớp cha
=> Có thể hiểu khi có từ khóa Virtual thì lớp con có thể sửa phương thức của lớp cha còn nếu không thì ngược lại
!Lưu Ý:
    !Chỉ có thể ghi đè lên phương thức virtual hoặc abstract
    !Tính đa hình được thể hiện khi ghi đè lên phương thức của lớp cha

    => không có từ khóa override thì không thể thực hiện đa hình 
?Lớp trừu tượng và phương thức thuần ảo
*Phương thức thuần ảo là một phương thức ảo không có định nghĩa bên trong 
*Lớp trừu tượng là lớp chứa phương thức thuần ảo
*Abstract là từ khóa dùng để khai báo lớp trừu tượng hoặc một phưong thức thuần ảo
Xét lại ví dụ trên, ở đây ta xem lại phương thức Speak() của Animal và nhận thấy 
Phần định nghĩa của phương thức này chỉ là hình thức và sau đó cũng bị các lớp thừa kế khác ghi đè lên =
=> vậy việc định nghĩa nội dung phương thức không có tác dụng gì tại sai ta phải định nghĩa chúng 
Câu trả lời được C# giải đáp thông qua từ khóa Abstract. Ở đây ta sử dụng Abstract để nhấn mạnh 2 điều
    *Phương thức Speak() có thể ghi đè
    *Phương thức Speak() không có định nghĩa gì bên trong 

Để khai báo lớp trừu tượng, lớp thức thuần ảo ta chỉ cần thêm từ khóa Abstract trước tên lớp hoặc phương thức

!Lưu ý:
!Khi kế thừa một lớp trừu tượng bạn bắt buộc phải override tất cả các phương thức thuần ảo nhằm đảm bảo tính hợp lệ cho chương trình.
!Lớp có hàm thuần ảo phải có từ khóa abstract

*/