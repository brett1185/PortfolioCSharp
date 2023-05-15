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
}