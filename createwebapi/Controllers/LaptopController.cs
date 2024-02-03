using Microsoft.AspNetCore.Mvc;
using CreateWebapi.Data;
using CreateWebapi.Model;
using Microsoft.EntityFrameworkCore;
namespace CreateWebapi.Controllers{
[ApiController]

  public class AddController : ControllerBase{
      private readonly AppDbContext context;
        public AddController(AppDbContext context){
            this.context=context; 
        }
    [Route("api/AddLaptop")]
     [HttpPost]
    public async Task<IActionResult> Post(LaptopDetails laptopDetails)
    {
            try
            {
                context.Add(laptopDetails);
                await context.SaveChangesAsync();
                return Ok();
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
    }

  }
}