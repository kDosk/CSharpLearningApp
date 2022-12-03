using CSharpLearningApp.Classes.Exceptions;
using CSharpLearningApp.Models.UserModels;
using System;
using System.Windows;

namespace CSharpLearningApp.Classes.AuthorizationService
{
	public class AuthorizationManager
	{
		public static User CurrentUser { get; set; } = null;

		public static bool SignUp(string name, string surname, string login, string password, string confitmPassword)
		{
			bool toggle = false;
			try
			{
				Authorization.AddUser(name, surname, login, password, confitmPassword);
				MessageService.MessageService.ShowMessage("Успешно!");
				toggle = true;
			}
			catch (ArgumentNullException)
			{
				MessageService.MessageService.ShowError("Проверьте введенные данные.");
			}
			catch (PasswordsAreNotEqualsException)
			{
				MessageService.MessageService.ShowError("Пароли не совпадают.");
			}
			catch (LoginIsExistException)
			{
				MessageService.MessageService.ShowError("Введенный логин занят.");
			}
			catch (AuthorizationErrorException)
			{
				MessageService.MessageService.ShowError("Ошибка регистрации.");
			}
			return toggle;
		}
		public static bool SignIn(string login, string password)
		{
			bool toogle = false;

			try
			{
				CurrentUser = Authorization.GetUser(login, password);
				MessageService.MessageService.ShowMessage("Успешно!");
				toogle = true;
			}
			catch (ArgumentNullException)
			{
				MessageService.MessageService.ShowError("Проверьте введенные данные.");
			}
			catch (AuthorizationErrorException)
			{
				MessageService.MessageService.ShowError("Ошибка регистрации.");
			}
			catch (UserNotFoundException)
			{
				MessageService.MessageService.ShowError("Пользователь не найден.");
			}
			catch (IncorrectPasswordException)
			{
				MessageService.MessageService.ShowError("Неверный пароль.");
			}

			return toogle;
		}
	}
}
