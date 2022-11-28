using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Models.PageModels.TestModels
{
	public class TestList
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int SubtitleID { get; set; }

        public virtual Subtitle Subtitle { get; set; }
        public virtual List<TestQuestion> TestQuestions { get; set; } = new List<TestQuestion>();

    }
}
