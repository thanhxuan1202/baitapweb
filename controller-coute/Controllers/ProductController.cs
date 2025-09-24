using Microsoft.AspNetCore.Mvc;

namespace controller_route.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult index()
        {
            ViewData["Title"] = "Danh Sách Sản Phẩm";
            return View();
        }
        public IActionResult Detail(int id)
        {
            ViewData["Title"] = $"Chi Tiết Sản Phẩm - ID: {id}";
            ViewData["ProductId"] = id;
            return View();
        }
    }
}