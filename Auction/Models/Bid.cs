using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Auction.Models
{
	public class Bid
	{
		public int Id { get; set; }
		public double Amount { get; set; }

		[Required]
		public string? IdentityUserId { get; set; }
		[ForeignKey("IdentityUserId")]
		public IdentityUser? User { get; set; }
	}
}