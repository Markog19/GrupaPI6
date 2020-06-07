using Microsoft.AspNetCore.Mvc;

namespace OzoMVC.ViewComponents{
public class NavigationViewComponent:ViewComponent{
    public IViewComponentResult Invoke(){
        ViewBag.Controller = RouteData?.Values["controller"];
        return View();
    }
}
}