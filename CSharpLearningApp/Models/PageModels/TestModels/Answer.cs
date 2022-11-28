using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.Models.PageModels.TestModels
{
    public class Answer
    {
        public int ID { get; set; }
        public string Value { get; set; }
        public bool IsCorrect { get; set; } = false;
        public int TestQuestionID { get; set; }

        public virtual TestQuestion TestQuestion { get; set; }
    }
}
