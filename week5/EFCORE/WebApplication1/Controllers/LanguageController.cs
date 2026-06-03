using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [Route("/api/languages")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly AppDBContext _dbContext;
        public LanguageController(AppDBContext dBContext)
        {
            this._dbContext = dBContext;
        }

        [HttpGet()]
        public IActionResult getAllLanguages()
        {
            var result = this._dbContext.Languages.ToList();

            return Ok(result);
        }
    }
}
