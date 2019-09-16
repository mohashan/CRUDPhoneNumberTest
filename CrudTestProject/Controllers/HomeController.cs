using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CrudTestProject.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;
using PhoneNumbers;

namespace CrudTestProject.Controllers
{
	public class HomeController : Controller
	{
		private readonly ApplicationDbContext ctx;
		private readonly IMapper mapper;

		public HomeController(ApplicationDbContext applicationDbContext,IMapper mapper)
		{
			this.ctx = applicationDbContext;
			this.mapper = mapper;
		}
		public IActionResult Index()
		{
			//ctx.Customer.AsNoTracking().Select(c).ToList());
			return View(mapper.ProjectTo<CustomerVM>(ctx.Customer.AsNoTracking()).ToList());
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public async Task<string> Create(CustomerVM Model)
		{
			
			if (!ModelState.IsValid)
			{
				return "Input Data is invalid";
			}
			PhoneNumberUtil phoneUtil = PhoneNumberUtil.GetInstance();
			try
			{
				if (string.IsNullOrEmpty(Model.CountryCode) || string.IsNullOrEmpty(Model.CountryISO))
					throw new Exception("Invalid Number");
				Model.PhoneNumber = Convert.ToUInt64(Model.PhoneNumber).ToString();
				PhoneNumber phoneNo = phoneUtil.Parse(Model.PhoneNumber, Model.CountryISO.ToUpper());
				if (!phoneUtil.IsValidNumber(phoneNo))
					throw new Exception("Number is invalid");
			}
			catch (NumberParseException e)
			{
				return "Phone Number is invalid";
			}
			try
			{
				var customer = mapper.Map<CustomerVM, Customer>(Model);
				await ctx.Customer.AddAsync(customer);
				await ctx.SaveChangesAsync();
				return "true";
			}
			catch (Exception)
			{
				return "Saving Data was failed";
			}
			
		}

		[HttpGet]
		public async Task<IActionResult> Edit(int Id)
		{
			var customer = await ctx.Customer.FindAsync(Id);
			var customerVM = mapper.Map<Customer, CustomerVM>(customer);
			if(customer == null)
			{
				//Customer Not Found
				return RedirectToAction("Index");
			}
			return View(customerVM);
		}

		[HttpPost]
		public async Task<string> Edit(CustomerVM Model)
		{
			if (!ModelState.IsValid)
			{
				return "Input Data is invalid";
			}
			PhoneNumberUtil phoneUtil = PhoneNumberUtil.GetInstance();
			try
			{
				if (string.IsNullOrEmpty(Model.CountryCode) || string.IsNullOrEmpty(Model.CountryISO))
					throw new Exception("Invalid Number");
				Model.PhoneNumber = Convert.ToUInt64(Model.PhoneNumber).ToString();
				PhoneNumber phoneNo = phoneUtil.Parse(Model.PhoneNumber, Model.CountryISO.ToUpper());
				if (!phoneUtil.IsValidNumber(phoneNo))
					throw new Exception("Number is invalid");
			}
			catch (NumberParseException e)
			{
				//log
				return "Phone Number is invalid";
			}
			var customer = ctx.Customer.Find(Model.Id);
			customer.BankAccountNumber = Model.BankAccountNumber;
			customer.DateOfBirth = Model.DateOfBirth;
			customer.Email = Model.Email;
			customer.FirstName = Model.FirstName;
			customer.LastName = Model.LastName;
			customer.CountryCode = Model.CountryCode;
			customer.CountryISO = Model.CountryISO;

			try
			{
				ctx.Entry<Customer>(customer).State = EntityState.Modified;
				await ctx.SaveChangesAsync();
				return "true";
			}
			catch (Exception e)
			{
				//log
				return "Saving data was failed";
			}
			
		}

		[HttpGet]
		public async Task<IActionResult> Delete(int Id)
		{
			try
			{
				var customer = await ctx.Customer.FindAsync(Convert.ToInt32(Id));
				var customerVM = mapper.Map<Customer, CustomerVM>(customer);
				if (customer != null)
				{
					ctx.Customer.Remove(customer);
					ctx.SaveChanges();
				}
			}
			catch (Exception)
			{
				//log
			}
			return RedirectToAction("Index");



		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
