﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudTestProject.Models.Mapping
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			// Add as many of these lines as you need to map your objects
			CreateMap<Customer, CustomerVM>();
			CreateMap<CustomerVM, Customer>();
		}
	}
}
