using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudTestProject.Models
{
	public class ApplicationDbContext : DbContext
	//DbContext
	{
		public ApplicationDbContext(DbContextOptions options)
			: base(options)
		{

		}
		public DbSet<Customer> Customer { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<Customer>()
				.HasIndex(u => u.Email)
				.IsUnique();

			builder.Entity<Customer>()
			.HasIndex(p => new { p.FirstName, p.LastName,p.DateOfBirth })
			.IsUnique();

		}
	}
}
