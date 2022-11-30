using CSharpLearningApp.Models.PageModels.TestModels;
using CSharpLearningApp.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Models.PageModels
{
	public class PracticeScoreLog
	{
		public int ID { get; set; }
		public int UserID { get; set; }
		public int PracticeID { get; set; }
		public int Score { get; set; }

		public User User { get; set; }
		public Practice Practice { get; set; }
	}
}
