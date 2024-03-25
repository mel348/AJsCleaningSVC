using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using AJsCleaning.Data;

namespace AJsCleaning.Models
{
	public class Team
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; } = String.Empty;
		[Required]
		public string Title { get; set; } = String.Empty;
		[Required]
		public string Description { get; set; } = String.Empty;

		public string PhotoPath { get; set; } = String.Empty;
	}
}
