using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Models.PageModels
{
	public class Theory
    {
        public int ID { get; set; }
        public string TheoryContent { get; set; }
        public int SubtitleID { get; set; }

        public Subtitle Subtitle { get; set; }
    }
}
