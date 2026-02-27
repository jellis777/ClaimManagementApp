using ClaimManagementAPI.Data;
using ClaimManagementAPI.Models;

namespace ClaimManagementAPI.Services
{
    public class ClaimService
    {
        private readonly AppDbContext _context;

        public ClaimService(AppDbContext context)
        {
            _context = context;
        }

        public List<Claim> GetAllClaims()
        {
            return _context.Claims.ToList();
        }

        public Claim? GetClaimById(int id)
        {
            return _context.Claims.FirstOrDefault(c => c.Id == id);
        }

        public Claim CreateClaim(Claim claim)
        {
            _context.Claims.Add(claim);
            _context.SaveChanges();
            return claim;
        }

        public Claim? UpdateClaim(int id, Claim updatedClaim)
        {
            var existing = _context.Claims.FirstOrDefault(c => c.Id == id);

            if (existing == null)
                return null;

            existing.CustomerName = updatedClaim.CustomerName;
            existing.Amount = updatedClaim.Amount;
            existing.Status = updatedClaim.Status;

            _context.SaveChanges();

            return existing;
        }

        public bool DeleteClaim(int id)
        {
            var claim = _context.Claims.FirstOrDefault(c => c.Id == id);

            if (claim == null)
                return false;

            _context.Claims.Remove(claim);

            _context.SaveChanges();

            return true;
        }
    }
}