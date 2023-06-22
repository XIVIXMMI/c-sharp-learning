using System;
using System.Text.RegularExpressions;
namespace Program
{
    class Program{
        static void Main(string[]agrs){
        // Regex reg = new Regex(@"\d");
        // Match result = reg.Match("-howkteam.com 10092016-");
            // #region  MatchCollection - Cách 1
            // Console.WriteLine(result.ToString());
            // #endregion

            // #region MatchCollection - Cách 2
            // do{
            //     Console.WriteLine(result.ToString());
            //     result = result.NextMatch();
            // }while (result != Match.Empty);
            // #endregion

            // #region MatchCollection - Cách 3
            // foreach (Match item in reg.Matches("-howkteam.com 10092016-"))
            // {
            //     Console.WriteLine(item.ToString());
            // }
                
            // #endregion

            // #region Group and GroupCollection
            // /*Tạo 1 biểu thức*/
            // Regex re = new Regex(@"(?<hours>\d+):(?<minutes>\d+):(?<seconds>\d+)");
            // /*duyệt qua các kết quả trùng khớp
            // Lấy ra giá trị của các group thông qua chỉ số phần tử là tên các group đã đặt trong biểu thức*/
            // foreach (Match item in re.Matches("30/4/1975 10:30:12 192.168.1.2"))
            // {
            //     Console.WriteLine("Match: "+ item.ToString());
            //     Console.WriteLine("Hours: "+ item.Groups["hours"]);
            //     Console.WriteLine("Minutes: "+ item.Groups["minutes"]);
            //     Console.WriteLine("Seconds: "+ item.Groups["seconds"]);
            // }    
            // #endregion

            #region Capture and Capture Collection
                //Regex RE = new Regex(@"(?<time>(\d|:)+)\s"+@"(?<company>\S+)\s"+@"(?<ip>(\d|\.)+)\s"+@"(?<company>\S+)");
                Regex RE = new Regex(@"(?<time>(\d|:)+)\s(?<company>\S+)\s(?<ip>(\d|\.)+)\s(?<company>\S+)");
                foreach (Match item in RE.Matches("10:30:15 IBM 192.168.1.2 INTEL"))
                {
                    Console.WriteLine(" time: "+item.Groups["time"]);
                    Console.WriteLine(" ip: "+item.Groups["ip"]);
                    Console.WriteLine(" company: ");
                
                /*
                Lấy ra tất cả các capture bắt được trong group company và duyệt luần lượt chúng 
                sau đó ta có thể sử dụng ToString() hoặc thuộc tính Value để lấy lần lượt gía trị của Capture
                */
                    foreach (Capture i in item.Groups["company"].Captures)
                    {
                        Console.Write(i.ToString()+ " ");
                    }
                }
            #endregion
            
        }
    }
}
/*
    Định nghĩa: 
    Regular Expression hay tiếng Việt được gọi là biểu thức chính quy,
    là một cấu trúc rất mạnh để mô tả một chuỗi theo cách thống nhất chung.
    Bao gồm tập hợp các ký tự, toán tử hay ký hiệu toán học nhầm biểu thị 1 chuỗi
    theo cấu trúc chung mà mọi người học theo, có thể xem Regular Exppression
    là một loại tiếng lóng dùng chung trong lập trình.

    Các ký hiệu:
    chuỗi mẫu
        -howkteam.com-10092016-
    Pattern: 
        \d{8}
    Kết quả tìm kiếm
        10092016
    Một cách nhìn khác:
        -howkteam.com-10092016-
    Hay một cách dễ nhớ:
        -howkteam.com-\d{8}-
`       \d là ký hiệu biểu thị cho số
        {8} là biểu thị ký tự trước đó xuất hiện 8 lần
        vậy vó thể đọc âu pattern này là: Tìm ra chuỗi con là dãy 8 số liên tiếp nhau.
        => kết quả là trùng khớp.
    Nếu bạn thay số 8 thành số 6 tức là pattern thành: \d{6}
    Thì kết quả thành: 100920 
        -howkteam.com-10092016-
        hay một cách dễ nhớ: 
        -howkteam.com-\d{6}16-

    => Regular Expression bản chất là tìm ra một hoặc nhiều chuỗi con thỏa mãn cấu trúc chung được định ra.

    Một số ký hiệu thông dụng: 
    . : đại diện cho một ký tự bất kì ngoại trừ ký hiệu \n.
    \d: đại diện cho ký tự số, tương đương pattern [0-9].
    \D: Ký tự không phải số. Hay có thể hiểu là phủ định của \d.
    \s: ký tự khoảng trắng. tương đương [\f\n\r\t\v].
    \S: Ký tự không phải khoảng trắng, tương đương phủ định của \s hay tương đương [^\f\n\r\t\v].
    \w: Ký tự word (chữ cái và số, dấu gạch dưới_) tương đương [a-zA-Z_0-9].
    \W: Ký tự không phải word, tương đương phủ định của \w hay [^a-zA-Z_0-9].
    ^: Bắt đầu một chuỗi hay một dòng.
    $: Kết thúc một chuỗi hay một dòng.
    \A: Bắt đầu một chuỗi.
    \z: kết thúc một chuỗi
    | : Ký tự so trùng tương đương OR 
    [abc]: Khớp với 1 ký tự nằm trong nhóm này "abc"
    [a-z]: Khớp với ký tự trong khoảng a đến z, a và z là ký tự hiện hữu trong bản ASCII
    () : xác định 1 group, 1 biểu thức đơn lẻ trong pattern
    ? : Khớp với từ đứng trước xuất hiện 0 hay 1 lần.
    * :Khớp với từ đứng trước 0 lần trở lên.
    + : Khớp với từ đứng trước 1 lần trở lên.
    {n}: Với n là số, khớp với từ đứng trước 
    {n,}: Với n là số, Khớp với từ đứng trước n lần trở lên
    {m,n}: Với m và n là số, khớp với từ đứng trước xuất hiện trừ m đến n lần.
    
    Dùng phần mềm RegEx tester để demo cách dùng Regular Expression.

    Một số lớp hỗ trợ:
    Match và MatchCollection 
    Khi áp dụng một biểu thức quy tắc lên 1 chuõi nào đó thì kết quả trả về có thể là nhiều chuỗi con
    thỏa mãn biểu thức quy tắc trên. Khi đó các chuỗi con sẽ được lưu vào trong 1 tập hợp
    có tên là MatchCollection, mỗi phần tử trong tập hợp là một biến có kiểu Match 
    MatchCollection là 1 kiểu tập hợp chứa danh sách các đối tượng kiểu Match. Vì đây cũng là 1 tập hợp bình thường
    nên có thể có thao tác như các tập hợp khác.
    Một đối tượng kiểu Match sẽ chứa 1 chuỗi con kết quả, để xem chuỗi con kết quả này 
    ta sẽ gọi phương thức toString(). Ngoài ra nó cũng có các thuộc tính và phương thức khác như: 
    Captures: Lấy ra danh sách các đối tượng kiểu Capture 
    Groups: Lấy ra danh sách các đối tượng kiểu Group
    Index: Trả về vị trí của chuỗi con trung khớp trong chuỗi gốc
    Length: Trà về độ dài của chuỗi con trùng khớp.
    Empty: Trả về một đối tượng Match rỗng. Khi muốn kiểm tra 1 đối tượng Match có rỗng hay không ta sẽ so sánh chúng với Empty
    Success: Trả về kiểu bool cho biết có tìm dược chuỗi con nào trùng khớp hay không.
    Value: trả về giá trị trùng khớp.
    ToString():Trả về chuỗi con trùng khớp (khác với Value, ToString() chỉ trả về chuỗi trong mọi trường hợp
    còn Value sẽ trả về đúng giá trị mà mình lấy, ví dụ lấy ra số thì sẽ trả về giá trị số)
    NextMatch(): Trả về một đối tượng kiểu Match mới là giá trị trùng khớp tiếp theo (Nếu có).

    Group và GroupCollection
    Group trong regular expression là chỉ các ta gom nhóm các biểu thức lại thành cụm và có thể đặt tên cho nhóm để dễ quản lý và thao tác
    Lớp Group là 1 lớp đại diện cho 1 gom nhóm trong biểu thức, có 1 điểm chúng ta nên biết là lớp Group là lớp cha của Match
    Bởi vì: 
    Trong 1 kết quả trùng khớp sẽ có thể chứa nhiều thông tin khác nhau và ta mong muốn có thể 
    lấy ra từng thành phần nhỏ trong đó mà không phải dùng thêm 1 biểu thức chính quy nào nữa.
    Và trong biểu thức chính quy ban đầu ta sẽ gom nhóm các thành phần cpn thành các group và đặt tên cho chúng 
    như vậy khi lấy được 1 chuỗi kết quả ta muốn lấy các thành phần con bên trong đó thì ta chỉ càn gọi chúng thông qua tên đặt.
    Syntax: (?<tên group>)
    Trong đó: 
    () là cú pháp gom nhóm biểu thức
    ?<tên group> là cú pháp đặt tên cho group,có thể không đặt tên, tên phải viết liền không dấu
    
    Ví dụ:
    Để lấy ra chuõi giờ phút giây ta có thể làm như sau:
    "\d+:\d+:\d+"
    Nếu bây giờ muốn lấy ra giờ, phút, giây riêng để xử lý thì làm sao ?
    Sử dụng Group và đặt tên cho chúng như sau:
    (?<hours>\d+):(?<minutes>\d+):(?<seconds>\d+)
    Trong đó: "hours","minutes","seconds" là tên đặt cho 3 group 

    Capture và CaptureCollection
    Mỗi khi tìm thấy bất kì 1 chuỗi con nào bao gồm cả các group thì C# sẽ bắt nó lại là lưu vào 1 đối tượng có kiểu capture
    Và danh sách tất cả các Capture chính là 1 Capture Collection
    Capture là lớp cha của lớp Group
    Ví dụ:
    Cho chuỗi "10:30:15 IBM 192.168.1.2 INTEL" viết biểu thức lấy ra giờ phút giây địa chỉ IP và địa chỉ cty

    (?<time>(\d|:)+)\s(?<company>\S+)\s(?<ip>(\d|\.)+)\s(?company>\S+)
*/