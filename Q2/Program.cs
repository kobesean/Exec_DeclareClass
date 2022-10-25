using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Telephone telephone = new Telephone();
			telephone.CountryCode = "123";
			telephone.AreaCode = "123";
			telephone.Number = "0226555555";
			telephone.Ext = "123";
		}
	}
	class Telephone
	{
		public string CountryCode { get; set; }
		public string AreaCode { get; set; }
		public string Number { get; set; }
		public string Ext { get; set; }
	}
}
