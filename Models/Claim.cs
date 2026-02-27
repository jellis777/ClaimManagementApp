using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaimManagementAPI.Models
{
    public class Claim
    {
        public int Id { get; set; }

        public string CustomerName { get; set; }

        public decimal Amount { get; set; }

        public string Status { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}