using CSharpLearningApp.Models.UserModels;

namespace CSharpLearningApp.Classes.AuthorizationService
{
	public class AuthorizationManager
	{
		public static User CurrentUser { get; set; } = null;

		public static bool SignUp(string name, string surname, string login, string password, string confitmPassword)
		{
			bool toogle = false;
			if (NotNullValidation(name, surname, login, password, confitmPassword))
			{
				if (password == confitmPassword)
				{
					var user = Authorization.AddUser(name, surname, login, password);
					if (user == null)
					{
						MessageService.MessageService.ShowError("Ошибка регистрации.");
					}
					else
					{
						CurrentUser = user;
						MessageService.MessageService.ShowMessage("Успешно!");
						toogle = true;
					}
				}
				else
				{
					MessageService.MessageService.ShowError("Пароли не совпадают.");
				}
			}
			return toogle;
		}
		public static bool SignIn(string login, string password)
		{
			bool toogle = false;
			if (NotNullValidation(login, password))
			{
				var user = Authorization.GetUser(login, password);
				if (user == null)
				{
					MessageService.MessageService.ShowError("Проверьте введенные данные.");
				}
				else
				{
					CurrentUser = user;
					MessageService.MessageService.ShowMessage("Успешно!");
					toogle = true;
				}
			}
			return toogle;
		}

		private static bool NotNullValidation(params string[] strings)
		{
			bool result = true;
			foreach (string s in strings)
			{
				if (string.IsNullOrWhiteSpace(s))
				{
					result = false;
					MessageService.MessageService.ShowError("Проверьте введенные данные!");
					break;
				}
			}
			return result;
		}
	}
}
