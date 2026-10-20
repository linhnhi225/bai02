using Microsoft.AspNetCore.Mvc;

namespace bai2_ASP.Controllers
{
    public class HelloController : Controller
    {
        public String Greeting()
        {
            return "Chào mừng";
        }
        public  string Welcome (int id,string name)
        {
            return $"bạn {id} {name} đến với ASP";
        }
        public IActionResult Welcome1(int id1,string name)
        {
            ViewBag.Id=id1;
            ViewData["Name"]=name;
            return View();
        }
    }
}
