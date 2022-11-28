using CSharpLearningApp.Classes;
using CSharpLearningApp.Models.PageModels;
using CSharpLearningApp.Models.PageModels.TestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.PageData.PageByKamilya
{
    public class PageTitleData : PageDataBasic
	{
		private readonly ApplicationContext _db;
		public PageTitleData()
		{
			_db = ApplicationContext.GetContext();
		}

		public void AddData(string titleName)
		{
			if (!_db.Titles.ToList().Exists(p => p.Name == titleName))
			{
				Title title = new Title { Name = titleName }; // Create title

				#region Create Practice
				Practice practice = new Practice
				{
					Task = "Задача",
					CorrectAnswer = "Правильный ответ",
					Title = title
				}; 
				#endregion

				title.Practice = practice; // Add practice to title

				#region Add subtitles to title
				title.Subtitles.AddRange(new List<Subtitle>
				{
					Subtitle_1("Глава 1. Переменные",
							   "Теория",
							   title),
					Subtitle_2("Глава 2. Константы",
							   "Теория",
							   title)
				}); 
				#endregion

				_db.Titles.Add(title); // Add created title to db
				_db.SaveChanges();
			}
		}

		#region Subtitles
		private Subtitle Subtitle_1(string name, string theoryContent, Title title)
		{
			Subtitle subtitle = AddSubtitle(name, theoryContent, title);

			subtitle.TestList = TestList_1(subtitle);

			return subtitle;
		}

		private Subtitle Subtitle_2(string name, string theoryContent, Title title)
		{
			Subtitle subtitle = AddSubtitle(name, theoryContent, title);

			subtitle.TestList = TestList_2(subtitle);

			return subtitle;
		}

		private Subtitle AddSubtitle(string name, string theoryContent, Title title)
		{
			Subtitle subtitle = new Subtitle
			{
				Name = name,
				Title = title
			};

			Theory theory = new Theory
			{
				TheoryContent = theoryContent,
				Subtitle = subtitle
			};
			subtitle.Theory = theory;

			return subtitle;
		}
		#endregion

		#region TestLists
		private TestList TestList_1(Subtitle subtitle)
		{
			TestList testList = CreateTestList("Переменные: Тест", subtitle);

			testList.TestQuestions.Add(CreateQuestion("Как выглядит синтаксис определения переменной?",
													  new string[] { "имя_типа переменной", "имя тип_переменной", "тип имя_переменной" },
													  "тип имя_переменной",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("В каком варианте переменная представляет строку?",
													  new string[] { "String name", "String Name", "String = \"name\";" },
													  "String name",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Какой тип данных хранит набор символов Unicode?",
													  new string[] { "string", "bool", "int" },
													  "string",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Какие из следующих вариантов представляют корректное определение переменных:",
													  new string[] { "string name =Tom", "string name = \"Tom\";", "string name=(Tom)" },
													  "string name = \"Tom\";",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Код для вывода на Console?",
													  new string[] { "Console.WriteLine(Tom);", "Console.WriteLine(name);", "Console.WriteLine(name.Tom);" },
													  "Console.WriteLine(name);",
													  testList));

			return testList;
		}

		private TestList TestList_2(Subtitle subtitle)
		{
			TestList testList = CreateTestList("Константы: Тест", subtitle);

			testList.TestQuestions.Add(CreateQuestion("Какое ключевое слово используется для определения констант?",
													  new string[] { "void", "const", "if" },
													  "const",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Как определяется константа в коде?",
													  new string[] { "const string NAME = \"Tom\"", "const string NAME;", "NAME = \"Bob\";" },
													  "const string NAME = \"Tom\"",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Сколько форм имеют вещественные константы?",
													  new string[] { "2", "4", "6" },
													  "2",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Если мы храним некоторые данные, которых не надо изменять, что мы используем?",
													  new string[] { "Переменные", "Константы" },
													  "Константы",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Во что заключены символы в символьных константах?",
													  new string[] { "Дефис", "Скобки", "Апострофы" },
													  "Апострофы",
													  testList));

			return testList;
		} 
		#endregion
	}
}
