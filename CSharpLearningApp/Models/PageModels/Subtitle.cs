using CSharpLearningApp.Models.PageModels.TestModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Models.PageModels
{
	public class Subtitle
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TitleID { get; set; }


        public Title Title { get; set; }
        public Theory Theory { get; set; }
        public TestList TestList { get; set; }
    }
}
