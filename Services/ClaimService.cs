using ClaimManagementAPI.Models;

namespace ClaimManagementAPI.Services
{
    public class ClaimService
    {
        private static List<Claim> claims = new List<Claim>();

        public List<Claim> GetAllClaims()
        {
            return claims;
        }

        public Claim CreateClaim(Claim claim)
        {
            claims.Add(claim);
            return claim;
        }
    }
}