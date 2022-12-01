using CSharpLearningApp.Classes.AuthorizationService;
namespace AppTestProject
{
	[TestClass]
	public class AuthorizationUnitTest
	{
		[TestMethod]
		public void SignIn_NullValues()
		{
			string login = string.Empty;
			string pass = string.Empty;

			bool actual = AuthorizationManager.SignIn(login, pass);

			Assert.IsFalse(actual);
		}

		[TestMethod]
		public void SignIn_LoginIsNull()
		{
			string login = string.Empty;
			string pass = "123";

			bool actual = AuthorizationManager.SignIn(login, pass);

			Assert.IsFalse(actual);
		}

		[TestMethod]
		public void SignIn_PassIsNull()
		{
			string login = "123";
			string pass = string.Empty;

			bool actual = AuthorizationManager.SignIn(login, pass);

			Assert.IsFalse(actual);
		}

		[TestMethod]
		public void SignUp_NullValues()
		{
			string login = string.Empty;
			string pass = string.Empty;
			string passConfirm = string.Empty;
			string name = string.Empty;
			string surname = string.Empty;

			bool actual = AuthorizationManager.SignUp(name, surname, login, pass, passConfirm);

			Assert.IsFalse(actual);
		}

		[TestMethod]
		public void SignUp_PasswordsNotEquals()
		{
			string login = "login";
			string pass = "pass";
			string passConfirm = "123";
			string name = "name";
			string surname = "surname";

			bool actual = AuthorizationManager.SignUp(name, surname, login, pass, passConfirm);

			Assert.IsFalse(actual);
		}
	}
}