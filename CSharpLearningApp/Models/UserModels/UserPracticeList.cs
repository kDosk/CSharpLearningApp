using CSharpLearningApp.Models.PageModels;
using CSharpLearningApp.PageData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Models.UserModels
{
	public class UserPracticeList
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public bool IsPassed { get; set; } = false;
        public int PracticeID { get; set; }


        public virtual User User { get; set; }
        public virtual Practice Practice { get; set; }
    }
}
