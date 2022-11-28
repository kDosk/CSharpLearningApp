using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Models.PageModels
{
	public class Practice
    {
        public int ID { get; set; }
        public string Task { get; set; }
        public string CorrectAnswer { get; set; }
        public int TitleID { get; set; }

        public Title Title { get; set; }
    }
}
