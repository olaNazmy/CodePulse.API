using CodePulse.API.Data;
using CodePulse.API.Models.Domain;
using CodePulse.API.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodePulse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        public ApplicationBbContext context;
        public CategoriesController(ApplicationBbContext _context)
        {
            context = _context;
        }


        [HttpPost]
        public async Task<IActionResult> addCategory(CreateCategoryRequestDTO request)
        {
            //Map DTO to Domain Model 
            var category = new Category()
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle
            };
            context.Categories.Add(category);
            return Ok(category);
        }
    }
}
