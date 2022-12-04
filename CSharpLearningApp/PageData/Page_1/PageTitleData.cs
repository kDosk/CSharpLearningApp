using CSharpLearningApp.Classes;
using CSharpLearningApp.Models.PageModels;
using CSharpLearningApp.Models.PageModels.TestModels;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLearningApp.PageData.Page_1
{
	public class PageTitleData : PageDataBasic
	{
		public void AddData(string titleName)
		{
			var context = ApplicationContext.GetContext();
			if (!context.Titles.ToList().Exists(p => p.Name == titleName))
			{
				Title title = new Title { Name = titleName, TitleCreator = "C. Камиля" }; // Create title

				#region Create Practice
				Practice practice = new Practice
				{
					Task = "Выполните следующий код:\n" +
					"string GetValue() => \"Hello world!\"\n",
					CorrectAnswer = "Hello world!",
					Title = title
				};
				#endregion

				title.Practice = practice; // Add practice to title

				#region subtitles theory
				string theory_1 = "Синтаксис определения переменной выглядит следующим образом: \r" + "тип имя_переменной;\r\r" +
										  "Вначале идет тип переменной, потом ее имя. В качестве имени переменной может выступать любое произвольное название, которое удовлетворяет следующим требованиям:" +
										  "\r\r\n1.имя может содержать любые цифры, буквы и символ подчеркивания, при этом первый символ в имени должен быть буквой или символом подчеркивания" +
										  "\r\r\n2.в имени не должно быть знаков пунктуации и пробелов" +
										  "\r\r\n3.имя не может быть ключевым словом языка C#. Таких слов не так много, и при работе в Visual Studio среда разработки подсвечивает ключевые слова синим цветом." +
										  "\r\r\nХотя имя переменой может быть любым, но следует давать переменным описательные имена, которые будут говорить об их предназначении:" +
										  "\t\r\nstring name;" +
										  "\r\r\nВ данном случае определена переменная name, которая имеет тип string. то есть переменная представляет строку. Поскольку определение переменной представляет собой инструкцию, то после него ставится точка с запятой." +
										  "\r\r\nПри этом следует учитывать, что C# является регистрозависимым языком, поэтому следующие два определения переменных будут представлять две разные переменные:" +
										  "\t\r\nstring name;" +
										  "\t\r\nstring Name;" +
										  "\r\r\nПосле определения переменной можно присвоить некоторое значение:" +
										  "\t\r\nstring name;" +
										  "\t\r\nname = \"Tom\";" +
										  "\r\r\nТак как переменная name представляет тип string, то есть строку, то мы можем присвоить ей строку в двойных кавычках. Причем переменной можно присвоить только то значение, которое соответствует ее типу." +
										  "\t\r\nВ дальнейшем с помощью имени переменной мы сможем обращаться к той области памяти, в которой хранится ее значение." +
										  "\r\r\nТакже мы можем сразу при определении присвоить переменной значение. Данный прием называется инициализацией:" +
										  "\t\r\nstring name = \"Tom\";\r\n" +
										  "\r\r\nОтличительной чертой переменных является то, что в программе можно многократно менять их значение." +
										  "\t\r\nНапример, создадим небольшую программу, в которой определим переменную, поменяем ее значение и выведем его на консоль:" +
										  "\t\r\nstring name = \"Tom\";" +
										  "\t\r\nConsole.WriteLine(name); " +
										  "\t\r\nnname = \"Tom\";" +
										  "\t\r\nConsole.WriteLine(name); ";

				string theory_2 = "Отличительной особенностью переменных является то, что мы можем изменить их значение в процессе работы программы. Но, кроме того, в C# есть константы. Константа должна быть обязательно инициализирована при определении, и после определения значение константы не может быть изменено" +
									"\r\n\r\nКонстанты предназначены для описания таких значений, которые не должны изменяться в программе. Для определения констант используется ключевое слово const, которое указывается перед типом константы:" +
									"\r\r\nconst string NAME =\"Tom\";" +
									"\r\r\nТак, в данном случае определена константа NAME, которая хранит строку \"Tom\". Нередко для название констант используется верхний регистр, но это не более чем условность." +
									"\r\r\nПри использовании констант надо помнить, что объявить мы их можем только один раз и что к моменту компиляции они должны быть определены. Так, в следующем случае мы получим ошибку, так как константе не присвоено начальное значение:" +
									"\r\n\r\nconst string NAME;" +
									"\r\n\rКроме того, мы ее не сможем изменим в процессе работы программы:" +
									"\r\n\rconst string NAME = \"Tom\"; " +
									"\r\n\rNAME = \"Bob\";" +
									"\r\n\rТаким образом, если нам надо хранить в программе некоторые данные, но их не следует изменить, они определяются в виде констант. Если же их можно изменять, то они определяются в виде переменных.";
				#endregion

				#region Add subtitles to title
				title.Subtitles.AddRange(new List<Subtitle>
				{
					Subtitle_1("Глава 1. Переменные",
							   theory_1,
							   title),
					Subtitle_2("Глава 2. Константы",
							   theory_2,
							   title)
				});
				#endregion

				context.Titles.Add(title); // Add created title to db
				context.SaveChanges();
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
