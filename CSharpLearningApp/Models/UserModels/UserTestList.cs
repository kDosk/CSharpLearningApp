using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpLearningApp.Models.PageModels.TestModels;

namespace CSharpLearningApp.Models.UserModels
{
	public class UserTestList
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public bool IsPassed { get; set; } = false;
        public int TestListID { get; set; }


        public virtual User User { get; set; }
        public virtual TestList TestList { get; set; }
    }
}
