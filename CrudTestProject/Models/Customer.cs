using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudTestProject.Models
{
	public class Customer
	{
		[Key]
		public int Id { get; set; }


		[Display(Name = "First Name")]
		[StringLength(50)]
		[DataType("varchar")]
		[Required]
		public string FirstName { get; set; }

		[Display(Name = "Last Name")]
		[StringLength(50)]
		[DataType("varchar")]
		[Required]
		public string LastName { get; set; }

		[Display(Name = "Phone Number")]
		[StringLength(50)]
		[DataType("varchar")]
		[Required]
		public string PhoneNumber { get; set; }

		[Display(Name = "Country Code")]
		[StringLength(4)]
		[DataType("char")]
		[Required]
		public string CountryCode { get; set; }

		[Display(Name = "Country ISO")]
		[StringLength(2)]
		[DataType("char")]
		[Required]
		public string CountryISO { get; set; }

		[Display(Name = "Date Of Birth")]
		[Required]
		public DateTime DateOfBirth { get; set; }

		[Display(Name = "Email")]
		[StringLength(50)]
		[Required]
		public string Email { get; set; }

		[Display(Name = "Bank Account Number")]
		[StringLength(50)]
		[DataType("varchar")]
		[Required]
		public string BankAccountNumber { get; set; }
	}
}
