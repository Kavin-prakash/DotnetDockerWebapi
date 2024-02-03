using Microsoft.AspNetCore.Mvc;
using FetchWebapi.Data;
using FetchWebapi.Model;
using Microsoft.EntityFrameworkCore;
namespace FetchWebapi.Controllers{
[ApiController]
  public class FetchLaptopController : ControllerBase{
      private readonly Appdbcontext context;
        public FetchLaptopController(Appdbcontext context){
            this.context=context; 
        }
 
         [Route("api/FetchLaptop")]
         [HttpGet]
        public async Task<IEnumerable<LaptopDetails>>Get(){
            return await context.LaptopDetails.ToListAsync();
        }


        [Route("api/FetchLaptop/{id}")]
        [HttpGet]
        public ActionResult<LaptopDetails> GetIndividual(int id)
        {
           var movie = context.LaptopDetails.Find(id);
           if (movie == null)
           {
             return NotFound();
           }
           return Ok(movie);
         }

        [Route("api/TotalLaptops")]
        [HttpGet]
         public ActionResult<LaptopDetails> TotalCount()
        {
            var MovieCount=  context.LaptopDetails.ToList().Count;
            
            return Ok(MovieCount);
         }

        }
}
    
