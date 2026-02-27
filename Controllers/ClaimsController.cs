using Microsoft.AspNetCore.Mvc;
using ClaimManagementAPI.Models;
using ClaimManagementAPI.Services;

namespace ClaimManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClaimsController : ControllerBase
    {
        private readonly ClaimService _claimService;

        public ClaimsController(ClaimService claimService)
        {
            _claimService = claimService;
        }

        [HttpGet]
        public IActionResult GetClaims()
        {
            var claims = _claimService.GetAllClaims();
            return Ok(claims);
        }

        [HttpPost]
        public IActionResult CreateClaim(Claim claim)
        {
            var newClaim = _claimService.CreateClaim(claim);
            return Ok(newClaim);
        }
    }
}
