using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace commITMWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public string HelloWorld()
        {
            return "Hello World desde la nueva funcionalidad";
        }
    }
}
