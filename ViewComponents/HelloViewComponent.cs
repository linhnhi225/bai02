using Microsoft.AspNetCore.Mvc;
namespace bai2_ASP.ViewComponents
{
    public class HelloViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
