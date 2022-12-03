using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Classes.Exceptions
{
	public class IncorrectPasswordException : Exception
	{
		public string Password { get; set; }
		public IncorrectPasswordException(string password)
		{
			Password = password;
		}

		public IncorrectPasswordException(string message, string password) : base(message)
		{
			Password = password;
		}

		public IncorrectPasswordException(string message, Exception innerException, string password) : base(message, innerException)
		{
			Password = password;
		}
	}
}
