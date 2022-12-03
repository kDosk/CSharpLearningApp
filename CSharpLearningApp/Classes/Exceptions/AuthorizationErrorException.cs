using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Classes.Exceptions
{
	public class AuthorizationErrorException : Exception
	{
		public AuthorizationErrorException() { }

		public AuthorizationErrorException(string message) : base(message) { }

		public AuthorizationErrorException(string message, Exception innerException) : base(message, innerException) { }
	}
}
