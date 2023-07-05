## Controller 
- Là 1 lớp kế thừa từ lớp Controller: Microsoft.AspNetCore.Mvc.Controller

Trong Controller có sẵn các phương thức trả về các kiểu triển khai từ IActionResult như:

    Kiểu trả về                 | Phương thức
    ------------------------------------------------
    ContentResult               | Content()
    EmptyResult                 | new EmptyResult()
    FileResult                  | File()
    ForbidResult                | Forbid()
    JsonResult                  | Json()
    LocalRedirectResult         | LocalRedirect()
    RedirectResult              | Redirect()
    RedirectToActionResult      | RedirectToAction()
    RedirectToPageResult        | RedirectToRoute()
    RedirectToRouteResult       | RedirectToPage()
    PartialViewResult           | PartialView()
    ViewComponentResult         | ViewComponent()
    StatusCodeResult            | StatusCode()
    ViewResult                  | View()

- Action trong controller là một phương thúc public (không được static)
- Action có thể trả về bất kì kiểu dữ liệu nào, thường là ActionResult
- Các dịch vụ inject vào controller qua hàm tạo

## View 
- Là file .cshtml
- View cho Action lưu tại: /View/ControllerName/ActionName.cshtml
- Thêm thư mục lưu trữ cho view:
```
    {0} -> Action Name
    {1} -> Controller Name
    {2} -> Area Name
    options.ViewLocationFormats.Add("/MyView/{1}/{0}"+RazerViewEngine.ViewExtension);
```
## Truyền dữ liệu sang View
- Model
- ViewData
- ViewBag 
- TempData 