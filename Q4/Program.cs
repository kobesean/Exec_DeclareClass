using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Member member = new Member();
		}
		class Member
		{
			public void Register(string name, string Account, string Password, string ConfirmPassword, string Email);
		}
	}
}
