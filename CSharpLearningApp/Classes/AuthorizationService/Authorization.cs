using CSharpLearningApp.Classes.Exceptions;
using CSharpLearningApp.Models.UserModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace CSharpLearningApp.Classes.AuthorizationService
{
	internal class Authorization
	{
		public static void AddUser(string name, string surname, string login, string password, string confirmPassword)
		{
			if (!NotNullValidation(name, surname, login, password, confirmPassword))
			{
				throw new ArgumentNullException();
			}
			else if (password != confirmPassword)
			{
				throw new PasswordsAreNotEqualsException(password, confirmPassword);
			}
			else if (IsLoginBusy(login))
			{
				throw new LoginIsExistException(login);
			}
			else
			{
				try
				{
					ApplicationContext.GetContext().Users.Add(new User
					{
						Surname = surname,
						Name = name,
						Login = login,
						Password = HashingPassword(password),
					});
					ApplicationContext.GetContext().SaveChanges();
					AuthorizationManager.CurrentUser = GetUser(login, password);
				}
				catch (Exception)
				{

					throw new AuthorizationErrorException();
				}
			}
		}

		public static void RemoveUser(int ID)
		{
			var user = ApplicationContext.GetContext().Users.Select(p => p.ID == ID);
			ApplicationContext.GetContext().Remove(user);
		}

		public static User GetUser(string login, string password)
		{
			if (!NotNullValidation(login, password))
			{
				throw new ArgumentNullException();
			}
			else
			{
				User user;
				try
				{
					user = ApplicationContext.GetContext().Users.Where(p => p.Login == login).Include(p => p.UserTestList)
																										.Include(p => p.UserPracticeList).FirstOrDefault();
				}
				catch (Exception)
				{
					throw new AuthorizationErrorException();
				}

				if (user == null)
				{
					throw new UserNotFoundException(login, password);
				}
				else if (user.Password != HashingPassword(password))
				{
					throw new IncorrectPasswordException(password);
				}
				else
				{
					return user;
				}
			}
		}

		private static bool IsLoginBusy(string login)
		{
			bool toggle = false;
			foreach (var item in ApplicationContext.GetContext().Users)
			{
				if (item.Login == login)
				{
					toggle = true;
					break;
				}
			}
			return toggle;
		}

#pragma warning disable SYSLIB0021
		private static string HashingPassword(string password)
		{
			using (var sha256 = new SHA256Managed())
			{
				return BitConverter.ToString(sha256.ComputeHash(Encoding.UTF8.GetBytes(password))).Replace("-", "");
			}
		}
#pragma warning restore SYSLIB0021

		private static bool NotNullValidation(params string[] strings)
		{
			bool result = true;
			foreach (string s in strings)
			{
				if (string.IsNullOrWhiteSpace(s))
				{
					result = false;
					break;
				}
			}
			return result;
		}
	}
}
