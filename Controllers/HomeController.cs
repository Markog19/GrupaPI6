using Microsoft.AspNetCore.Mvc; 
namespace  OzoMVC.Controllers{


public class HomeController:Controller{
    public IActionResult Index(){
        return View();
         }
    }   
}