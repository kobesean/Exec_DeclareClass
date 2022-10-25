using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Member member = new Member();
			member.Name = "Sean";
			member.Account = "AAAAAA11111";
			member.Password = "AAAaaa123456";
			member.Email = "Sean@gmail.com";
			member.Address = "taiwan";
			member.NaCellPhoneme = "0912345678";
			member.TelePhone = "0212345678";
		}
	}
	class Member
	{
		public string Name { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }
		public string NaCellPhoneme { get; set; }
		public string TelePhone { get; set; }
	}
}
