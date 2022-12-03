using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Classes.Exceptions
{
	public class LoginIsExistException : Exception
	{
		public string Login { get; set; }
		public LoginIsExistException(string login)
		{
			Login = login;
		}

		public LoginIsExistException(string message, string login) : base(message)
		{
			Login = login;
		}

		public LoginIsExistException(string message, Exception innerException, string login) : base(message, innerException)
		{
			Login = login;
		}
	}
}
