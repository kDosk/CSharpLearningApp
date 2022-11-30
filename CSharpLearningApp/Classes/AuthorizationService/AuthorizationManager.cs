using CSharpLearningApp.Models;
using CSharpLearningApp.Classes.MessageService;
using CSharpLearningApp.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Classes.AuthorizationService
{
	internal class AuthorizationManager
	{
		public static User CurrentUser { get; set; } = null;

		public static void SignUp(string name, string surname, string login, string password, string confitmPassword)
		{
			if (password == confitmPassword)
			{
				var user = Authorization.AddUser(name, surname, login, password);
				if (user == null)
				{
					MessageService.MessageService.ShowMessage("Ошибка регистрации");
				}
				else
				{
					CurrentUser = user;
					MessageService.MessageService.ShowMessage("Успешно!");
				}
			}
			else
			{
				MessageService.MessageService.ShowError("Пароли не совпадают");
			}
		}
		public static void SignIn(string login, string password)
		{
			var user = Authorization.GetUser(login, password);
			if (user == null)
			{
				MessageService.MessageService.ShowMessage("Пользователь не найден");
			}
			else
			{
				CurrentUser = user;
				MessageService.MessageService.ShowMessage("Успешно!");
			}
		}

		
	}
}
