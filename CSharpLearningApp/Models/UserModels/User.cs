using System.Collections.Generic;

namespace CSharpLearningApp.Models.UserModels
{
	public class User
	{
		public int ID { get; set; }
		public string Surname { get; set; }
		public string Name { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }

		public List<UserTestList> UserTestList { get; set; } = new List<UserTestList>();
		public List<UserPracticeList> UserPracticeList { get; set; } = new List<UserPracticeList>();
	}
}
