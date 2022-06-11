using Microsoft.AspNetCore.Mvc;
using WebApiPractice.Models;
using WebApiPractice.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiPractice.Controllers
{
    // 驗證傳入數字與DB數字的差異 Controller
    [Route("api/[controller]")]
    [ApiController]
    public class ValidController : ControllerBase
    {
        private readonly IValidValueService _validValueService;

        public ValidController(IValidValueService validValueService)
        {
            _validValueService = validValueService;
        }


        // 驗證傳入數字與DB數字的差異 API
        // POST api/<ValidContro>
        [HttpPost]
        [Route("valid")]
        public List<int> Post([FromBody] ValueModel model)
        {
            return _validValueService.ValidValue(model.Values.ToList());
        }

    }
}
