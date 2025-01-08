using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class companyController : ControllerBase
    {

        IBll.IBlCompany c;
        public companyController(IBll.IBlCompany c)
        {
            this.c = c;
            
        }
        [HttpGet]
        public async Task<List<Dto.Company>> Get()
        {
            //Bll_Services.CoursesBll c = new Bll_Services.CoursesBll();
            return await c.Get();
        }
    }
}
