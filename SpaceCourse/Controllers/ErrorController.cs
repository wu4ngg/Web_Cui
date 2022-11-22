using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpaceCourse.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index(int id)
        {
            switch (id)
            {
                case 404:
                    {
                        ViewBag.ErrMsg = "Sai link rồi bạn ơi!!";
                        ViewBag.ErrImg = "~/Contents/img/icons/question-solid.svg";
                        ViewBag.ErrDesc = "Dữ liệu bạn đang tìm không tồn tại trong Cơ sở dữ liệu hoặc là dữ liệu rỗng. Vui lòng kiểm tra lại link.";
                        return View();
                    }
                case 403:
                    {
                        ViewBag.ErrMsg = "Admin only!!";
                        ViewBag.ErrImg = "~/Contents/img/icons/shield-solid.svg";
                        ViewBag.ErrDesc = "Bạn không có quyền truy cập trang Web này, vui lòng đăng nhập bằng một tài khoản ADMIN để tiếp tục.";
                        return View();
                    }
            }
            return View();
        }
    }
}