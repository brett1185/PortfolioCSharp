using Microsoft.AspNetCore.Mvc;
namespace First.Controllers;
public class IndexController : Controller{
    [HttpGet]
    [Route("")]
    public ViewResult Index(){
        ViewBag.Name = "Brett";
        return View("Index");
    }
}
public class ProjectsController : Controller{
    [HttpGet]
    [Route("projects")]
    public ViewResult Projects(){
        return View();
    }
}
public class ContactController : Controller{
    [HttpGet]
    [Route("contact")]
    public ViewResult Contact(){
        return View();
    }

    [HttpPost]
    [Route("process")]
    public RedirectResult FormInfo(string name, string email, string message){
        Console.WriteLine("Form Submitted");
   
    
        return Redirect("/");
    }
    }
