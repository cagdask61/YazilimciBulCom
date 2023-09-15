using Microsoft.AspNetCore.Mvc;

namespace YazilimciBulCom.Controllers
{
    [Route("callback")]
    public class CallbackController : Controller
    {
        public IActionResult Index()
        {
            return Json(new {naber="iyidirs"});
        }
    }
}
