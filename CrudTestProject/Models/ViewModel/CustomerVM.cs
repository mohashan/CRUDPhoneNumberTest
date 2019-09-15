using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudTestProject.Models
{
	public class CustomerVM
	{
		public int Id { get; set; }

		[Display(Name = "First Name")]
		[Required]
		[StringLength(50)]
		public string FirstName { get; set; }

		[Display(Name = "Last Name")]
		[Required]
		[StringLength(50)]
		public string LastName { get; set; }

		[Display(Name = "Phone Number")]
		[Required]
		[StringLength(50)]
		public string PhoneNumber { get; set; }

		[Display(Name = "Date Of Birth")]
		[Required]
		public DateTime DateOfBirth { get; set; }

		[Display(Name = "Email")]
		[Required]
		[StringLength(50)]
		public string Email { get; set; }

		[Display(Name = "Bank Account Number")]
		[Required]
		[StringLength(50)]
		public string BankAccountNumber { get; set; }


		[Display(Name = "Country Code")]
		[StringLength(4)]
		public string CountryCode { get; set; }

		[Display(Name = "Country ISO")]
		[StringLength(2)]
		public string CountryISO { get; set; }
	}
}
