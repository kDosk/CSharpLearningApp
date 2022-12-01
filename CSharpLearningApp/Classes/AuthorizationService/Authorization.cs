using CSharpLearningApp.Models.UserModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CSharpLearningApp.Classes.AuthorizationService
{
	internal class Authorization
	{
		public static User AddUser(string name, string surname, string login, string password)
		{
			try
			{
				if (!IsLoginBusy(login))
				{
					ApplicationContext.GetContext().Users.Add(new User
					{
						Surname = surname,
						Name = name,
						Login = login,
						Password = HashingPassword(password),
					});
					ApplicationContext.GetContext().SaveChanges();
					return GetUser(login, password);
				}
				else
				{
					return null;
				}
			}
			catch (Exception)
			{
				return null;
			}
		}

		public static void RemoveUser(int ID)
		{
			var user = ApplicationContext.GetContext().Users.Select(p => p.ID == ID);
			ApplicationContext.GetContext().Remove(user);
		}

		public static User GetUser(string login, string password)
		{
			try
			{
				var hashedPassword = HashingPassword(password);
				var user = ApplicationContext.GetContext().Users.Where(p => p.Login == login && p.Password == hashedPassword).Include(p => p.UserTestList)
																														   .Include(p => p.UserPracticeList);
				return user.FirstOrDefault();
			}
			catch (Exception)
			{
				return null;
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
	}
}
