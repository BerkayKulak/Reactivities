using Microsoft.AspNetCore.Mvc;
using Reactivities.Application.Followers;
using System.Threading.Tasks;

namespace Reactivities.API.Controllers
{
    public class FollowController : BaseApiController
    {
        [HttpPost("{username}")]
        public async Task<IActionResult> Follow(string username)
        {
            return HandleResult(await Mediator.Send(new FollowToggle.Command { TargetUsername = username }));
        }
    }
}
