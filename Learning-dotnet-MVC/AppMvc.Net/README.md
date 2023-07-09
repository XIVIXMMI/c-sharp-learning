## Controller
-   Là một lớp kế thừa từ lớp Controller: Microsoft.AspNetCore.Mvc.Controller 
-   Action trong controller là 1 phương thức public không được static 
-   Action trả về bất kì kiểu dữ liệu nào thường là IActionResult
-   Các dịch vụ inject vào controller qua hàm tạo 
## View
-   Là file cshtml
-   View cho Action lưu tại View/ControllerName/ActionName.cshtml
-   Thêm thư mục lưu trữ View
```
    {0} -> Action Name
    {1} -> Controller Name
    {2} -> Area Name
    options.ViewLocationFormats.Add("MyView/{1}/{0}"+RazorViewEngine.ViewExtension);
```
## Truyền dữ liệu sang View
-   Model 
-   ViewData
-   ViewBag
-   TempData
