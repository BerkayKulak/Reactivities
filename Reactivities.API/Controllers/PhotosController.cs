using Microsoft.AspNetCore.Mvc;
using Reactivities.Application.Photos;
using System.Threading.Tasks;

namespace Reactivities.API.Controllers
{

    public class PhotosController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromForm] Add.Command command)
        {
            return HandleResult(await Mediator.Send(command));
        }
    }
}
