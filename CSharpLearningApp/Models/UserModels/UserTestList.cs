using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpLearningApp.Models.PageModels.TestModels;

namespace CSharpLearningApp.Models.UserModels
{
    internal class UserTestList
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public bool IsPassed { get; set; } = false;
        public int TestListID { get; set; }


        public User User { get; set; }
        public TestList TestList { get; set; }
    }
}
