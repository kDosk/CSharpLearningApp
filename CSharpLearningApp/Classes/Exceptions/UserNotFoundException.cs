using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Classes.Exceptions
{
	public class UserNotFoundException : Exception
	{
		public string Login { get; set; }
		public string Password { get; set; }
		public UserNotFoundException(string login, string password)
		{
			Login = login;
			Password = password;
		}

		public UserNotFoundException(string message, string login, string password) : base(message)
		{
			Login = login;
			Password = password;
		}

		public UserNotFoundException(string message, Exception innerException, string login, string password) : base(message, innerException)
		{
			Login = login;
			Password = password;
		}
	}
}
