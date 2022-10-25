using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Address address = new Address();
			address.City = "Taipei";
			address.ZipCode = "123";
			address.Street = "light street";

		}
	}
	class Address
	{
		public string City { get; set; }
		public string ZipCode { get; set; }
		public string Street { get; set; }
	}
}
