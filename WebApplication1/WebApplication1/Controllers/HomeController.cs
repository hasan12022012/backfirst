using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ContentResult Index()
        {
            ContentResult result= new ContentResult();
            result.Content = "p138 Salam Content";
            result.ContentType = "tedt";
            result.StatusCode = 200;
            return result;

        }
        //public JsonResult Index()
        //{
        //    JsonResult jsonResult=new JsonResult("Salam");
        //    return jsonResult;
        //}
    }
}
