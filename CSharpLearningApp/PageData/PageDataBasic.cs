using CSharpLearningApp.Models.PageModels;
using CSharpLearningApp.Models.PageModels.TestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.PageData
{
    public class PageDataBasic
    {
        protected TestQuestion CreateQuestion(string question, string[] answers, string correctAnswer, TestList testList)
        {
            List<Answer> answersList = new List<Answer>();
            TestQuestion testQuestion = new TestQuestion
            {
                Question = question,
                CorrectAnswer = correctAnswer,
                TestList = testList
            };

            foreach (var answer in answers)
            {
                answersList.Add(new Answer
                {
                    Value = answer,
                    TestQuestion = testQuestion,
                });
            }
            testQuestion.Answers = answersList;
            return testQuestion;
        }

        protected TestList CreateTestList(string title, Subtitle subtitle)
        {
            return new TestList
            {
                Title = title,
                Subtitle = subtitle
            };
        }
    }
}
