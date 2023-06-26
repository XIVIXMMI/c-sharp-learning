
/*
?Collection là gì
Collection trong C# là :
*Các lớp hỗ trợ lưu trữ, quản lý và thao tác với đối tượng một cách có thứ tự
*Các lớp này nằm trong namespace System.Collections;
Một số đặc điểm của collection:
*Là một mảng có kích thước động:
    *=>Không cần khai báo số lượng phần tử khi khởi tạo
    *=>Có thể tăng giảm số lượng phần tử 1 trong mảng cách linh hoạt
*Có thể lưu trữ một tập hợp các đối tượng thuộc nhiều lớp khác nhau
*Hỗ trợ nhiều phương thức để thao tác với tập hợp như: tìm kiếm, sắp xếp, đảo ngược ...
*Mỗi collection được tổ chức thành 1 lớp nên cần khai báo đối tượng trước khi sử dụng (tạo instance )

Collection có gì hay hơn mảng ?

?Những điểm mạnh của collection

*Bên trong Collection có nhiều lớp đa dạng hỗ trợ cho các mục đích khác nhau. 
*Nếu như mảng chỉ có thể truy xuất phần tử thông qua chỉ số (index) thì collection có thể truy xuất thông qua index và key.

*Đối với danh sách cần thao tác tìm kiếm nhiều thì collection có lớp hỗ trợ 
*Giúp tìm kiếm nhanh hơn so với mảng nguyên thủy.(hashTable)

*Trong trường hợp danh sách cần thay đổi phần tử liên tục (thêm hoặc xóa phần tử) thì collection cũng hỗ trọ sẵn.(ArrayList)

*Ngoài ra trong namespace System.Collections cũng hỗ trợ sẵn 2 cấu trúc dữ liệu kinh điển là Stack và Queue
*Nên chỉ cần lấy ra sử dụng mà không cần cài đặt lại

Vậy khi nào sử dụng mảng và khi nào sử dụng collection ?

Mảng thường được dùng để làm việc với một số lượng cố định các đối tượng strongly-typed (là kiểu dữ liệu không bị thay đổi một các đột ngột, tường minh)
Collection cung cấp một cách linh hoạt hơn để làm việc với danh sách. Có thể tăng giảm số lượng phần tử tự động.
Một số Collections còn hỗ trợ lưu trữ dưới dạng key-value, giúp truy xuất nhanh chóng dễ dàng.

?Một số loại collection thông dụng

_________________________________________________________________________________________________________________
|       Lớp              |  Mô tả                                                                               |
|________________________|______________________________________________________________________________________|
|       ArrayList        |  Lớp cho phép lưu trữ và quản lý các phần tử giống mảng.                             |
|                        |  Tuy nhiên không giống như trong mảng, ta có thể thêm, xóa phần tử linh hoạt         |
|                        |  và có thể điều chỉnh kích cỡ 1 cách tự động.                                        |
|________________________|______________________________________________________________________________________|
|       HashTable        |  Lớp lưu trữ dưới dạng cặp key-value.                                                |
|                        |  Khi đó ta sẽ truy xuất các phần tử trong danh sách thông qua key                    |
|________________________|______________________________________________________________________________________|
|       SortedList       |  Là sự kết hợp của ArrayList và HashTable.                                           |
|                        |  Tức là dữ liệu lưu dưới dạng Key-Value, có thể truy xuất các phần tử thông qua key  |
|                        |  hoặc thông qua index, đặc biệt các phần tử trong danh sách này được sắp xếp         | 
|                        |  theo giá trị của Key.                                                               |
|________________________|______________________________________________________________________________________|
|       Stack            |  Lớp cho phép lưu trữ vào thao tác dữ liệu theo cấu trúc LIFO (Last In First Out).   |
|________________________|______________________________________________________________________________________|
|       Queue            |  Lớp cho phép lưu trữ và thao tác dữ liệu theo cấu trúc FIFO(First In First Out).    |
|________________________|______________________________________________________________________________________|
|       BitArray         |  Lớp cho phép lưu trữ và quản lý một danh sách các bit.                              |
|                        |  Giống mảng các phần tử kiểu Bool với true là 1 và false là 0                        |
|                        |  Ngoài ra BitArray còn hỗ trợ một số phương thức cho việc tính toán trên bit         |
|________________________|______________________________________________________________________________________|

TODO: Bản chất Collection là một object
*/