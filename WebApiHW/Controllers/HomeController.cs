using Microsoft.AspNetCore.Mvc;
using WebApiPractice.Models;
using WebApiPractice.Services;

namespace WebApiPractice.Controllers
{
    // 新增數字 Controller
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ISetValueService _setValueService;
        public HomeController(ISetValueService setValueService)
        {
            _setValueService = setValueService;
        }

        // 新增數字 API
        [HttpPost]
        [Route("set")]
        public string Set([FromBody]ValueModel model)
        {
            _setValueService.SetValueAsync(model.Values.ToList());
            return "ok";
        }
    }
}
