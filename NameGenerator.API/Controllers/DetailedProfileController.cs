using Microsoft.AspNetCore.Mvc;
using NameGenerator.Model.ViewModel;
using NameGenerator.Service.Interface;

namespace NameGenerator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailedProfileController : ControllerBase
    {
        private readonly IDetailedProfileService _detailedProfileService;
        public DetailedProfileController(IDetailedProfileService detailedProfileService)
        {
            _detailedProfileService = detailedProfileService;
        }
        [HttpPost]
        public IActionResult GeneratedProfile(BasicProfileDetailsRequestViewModel model)
        {
            var result = _detailedProfileService.GeneratedProfile(model);
            return Ok(result);
        }
    }
}
