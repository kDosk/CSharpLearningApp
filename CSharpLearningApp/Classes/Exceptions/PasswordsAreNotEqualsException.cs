using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Classes.Exceptions
{
	public class PasswordsAreNotEqualsException : Exception
	{
		public string Password { get; set; }
		public string ConfirmPassword { get; set; }
		public PasswordsAreNotEqualsException(string password, string confirmPassword)
		{
			Password = password;
			ConfirmPassword = confirmPassword;
		}

		public PasswordsAreNotEqualsException(string message, string password, string confirmPassword) : base(message)
		{
			Password = password;
			ConfirmPassword = confirmPassword;
		}

		public PasswordsAreNotEqualsException(string message, Exception innerException, string password, string confirmPassword) : base(message, innerException)
		{
			Password = password;
			ConfirmPassword = confirmPassword;
		}
	}
}
