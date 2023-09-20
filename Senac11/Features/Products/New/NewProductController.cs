using Microsoft.AspNetCore.Mvc;
using Senac11.Infra.Contexts;

namespace Senac11.Features.Products.New
{
    [ApiController]
    [Route("api/Product")]
    public class NewProductController : ControllerBase
    {
        private readonly NewProductHandler handler;

        public NewProductController(Senac11Context context)
        {
            handler = new NewProductHandler(context);
        }

        [HttpPost]
        [Route("New")]
        public async Task<IActionResult> Post([FromBody] NewProductCommand command)
        {
            NewProductResult result = await handler.Handle(command);

            if (result.Success)
                return Ok(result);

            return BadRequest(result);
        }
    }
}
