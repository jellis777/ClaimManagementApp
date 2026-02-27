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

        [HttpGet("{id}")]
        public IActionResult GetClaim(int id)
        {
            var claim = _claimService.GetClaimById(id);

            if (claim == null)
                return NotFound();

            return Ok(claim);
        }

        [HttpPost]
        public IActionResult CreateClaim(Claim claim)
        {
            var newClaim = _claimService.CreateClaim(claim);
            return Ok(newClaim);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateClaim(int id, Claim claim)
        {
            var updated = _claimService.UpdateClaim(id, claim);

            if (updated == null)
                return NotFound();

            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteClaim(int id)
        {
            var deleted = _claimService.DeleteClaim(id);

            if (!deleted)
                return NotFound();

            return Ok();
        }
    }
}
