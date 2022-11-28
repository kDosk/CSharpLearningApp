using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Models.PageModels.TestModels
{
	public class TestQuestion
    {
        public int ID { get; set; }
        public string Question { get; set; }
        public List<Answer> Answers { get; set; } = new List<Answer>();
        public string CorrectAnswer { get; set; }
        public int TestListID { get; set; }

        public TestList TestList { get; set; }

    }
}
