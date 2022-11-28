using CSharpLearningApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Classes.AuthorizationService
{
	internal class AuthorizationManager
	{
		//public static UserModel CurrentUser { get; set; } = null;

		//public static bool AddUser(string name, string login, string password, string surname)
		//{
		//	try
		//	{
		//		users.Add(new UserModel
		//		{
		//			ID = users.Count + 1,
		//			Surname = surname,
		//			Name = name,
		//			Login = login,
		//			Password = password
		//		});
		//		return true;
		//	}
		//	catch (Exception)
		//	{
		//		return false;
		//	}
		//}

		//public static void RemoveUser(int ID)
		//{
		//	users.Remove(users.Where(p => p.ID == ID).FirstOrDefault());
		//}

		//public static UserModel SearchUser(string login, string password)
		//{
		//	UserModel user = null;
		//	foreach (var item in users)
		//	{
		//		if (item.Login == login && item.Password == password)
		//		{
		//			user = item;
		//			break;
		//		}
		//	}
		//	return user;
		//}
	}
}
