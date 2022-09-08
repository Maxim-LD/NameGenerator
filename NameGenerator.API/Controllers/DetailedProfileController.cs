using Microsoft.AspNetCore.Mvc;
using NameGenerator.Model.ViewModel;
using NameGenerator.Service.Interface;
using System;

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

        [HttpPost("GenerateProfile")]
        public IActionResult GenerateProfile(BasicProfileDetailsRequestViewModel model)
        {
            var result = _detailedProfileService.GenerateProfile(model);
            return Ok(result);
        }

        [HttpGet("SearchById")]
        public IActionResult SearchById(Guid id)
        {
            var result = _detailedProfileService.SearchById(id);
            return Ok(result);
        }

        [HttpPut("UpdateProfile")]
        public IActionResult UpdateProfile(ProfileDetailsUpdateRequestViewModel model)
        {
            var result = _detailedProfileService.UpdateProfile(model);
            return Ok(result);
        }

        [HttpDelete("DeleteProfile")]
        public IActionResult DeleteProfile(Guid id)
        {
            var result = _detailedProfileService.DeleteProfile(id);
            return Ok(result);
        }
    }
}
