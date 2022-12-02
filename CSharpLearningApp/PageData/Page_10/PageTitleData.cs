using CSharpLearningApp.Classes;
using CSharpLearningApp.Models.PageModels.TestModels;
using CSharpLearningApp.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.PageData.Page_10
{
	internal class PageTitleData : PageDataBasic
	{
		public void AddData(string titleName)
		{
			var context = ApplicationContext.GetContext();
			if (!context.Titles.ToList().Exists(p => p.Name == titleName))
			{
				Title title = new Title { Name = titleName }; // Create title

				#region Create Practice
				Practice practice = new Practice
				{
					Task = "Напишите код, который выведет следующее: Hello world!",
					CorrectAnswer = "Hello world!",
					Title = title
				};
				#endregion

				title.Practice = practice; // Add practice to title

				#region Subtitles theory
				string theory_1 = "Метод может возвращать значение, какой-либо результат. В примере выше были определены два метода, которые имели тип void. Методы с таким типом не возвращают никакого значения. Они просто выполняют некоторые действия.\n" +
								"Но методы также могут возвращать некоторое значение. Для этого применяется оператор return, после которого идет возвращаемое значение:\n" +
								"return возвращаемое значение;\n" +
								"Например, определим метод, который возвращает значение типа string:\n" +
								"string GetMessage()\n" +
								"{\n" +
								"\treturn \"Hello\";\n" +
								"}\n" +
								"Метод GetMessage имеет тип string, следовательно, он должен возвратить строку. Поэтому в теле метода используется оператор return, после которого указана возвращаемая строка.\n" +
								"При этом методы, которые в качестве возвращаемого типа имеют любой тип, кроме void, обязательно должны использовать оператор return для возвращения значения. Например, следующее определение метода некорректно:\n" +
								"string GetMessage()\n" +
								"{\n" +
								"\tConsole.WriteLine(\"Hello\");\n" +
								"}\n" +
								"Также между возвращаемым типом метода и возвращаемым значением после оператора return должно быть соответствие. Например, в следующем случае возвращаемый тип - string, но метод возвращает число (тип int), поэтому такое определение метода некорректно:\n" +
								"string GetMessage()\n" +
								"{\n" +
								"\treturn 3; // Ошибка! Метод должен возвращать строку, а не число\n" +
								"}\n" +
								"После оператора return также можно указывать сложные выражения или вызовы других методов, которые возвращают определенный результат. Например, метод, который возвращает сумму чисел.";

				string theory_2 = "Также мы можем сокращать методы, которые возвращают значение:\n" +
								"string GetMessage()\n" +
								"{\n" +
								"\tConsole.WriteLine(\"Hello\");\n" +
								"}\n" +
								"аналогичен следующему методу:\n" +
								"string GetMessage() => \"Hello\";\n" +
								"А метод\n" +
								"int Sum(int x + int y)\n" +
								"{\n" +
								"\treturn x + y;\n" +
								"}\n" +
								"аналогичен следующему методу:\n" +
								"int Sum(int x, int y) => x + y";

				string theory_3 = "Оператор return не только возвращает значение, но и производит выход из метода. Поэтому он должен определяться после остальных инструкций. Например:\n" +
								"string GetHello()\n" +
								"{\n" +
								"\treturn \"Hello\";\n" +
								"\tConsole.WriteLine(\"After return\");" +
								"}\n" +
								"С точки зрения синтаксиса данный метод корректен, однако его инструкция Console.WriteLine(\"After return\") не имеет смысла - она никогда не выполнится, так как до ее выполнения оператор return возвратит значение и произведет выход из метода.\n" +
								"Однако мы можем использовать оператор return и в методах с типом void. В этом случае после оператора return не ставится никакого возвращаемого значения (ведь метод ничего не возвращает). Типичная ситуация - в зависимости от опеределенных условий произвести выход из метода:\n" +
								"void PrintPerson(string name, int age)\n" +
								"{\n" +
								"\tif ( age > 120 || age  < 1)\n" +
								"\t{\n" +
								"\t\tConsole.WriteLine(\"Ошибка\");" +
								"\t}\n" +
								"\tConsole.WriteLine($\"Имя: {name} Возраст: {age}\");" +
								"}\n" +
								"PrintPerson(\"Tom\", 37); // Имя: Tom Возраст: 37\n" +
								"PrintPerson(\"Dunkan\", 1234); // Недопустимый возраст\n" +
								"Здесь метод PrintPerson() в качестве параметров принимает имя и возраст пользователя. Однако в методе вначале мы проверяем, соответствует ли возраст некоторому диапазону (меньше 120 и больше 0). Если возраст находится вне этого диапазона, то выводим сообщение о недопустимом возрасте и с помощью оператора return выходим из метода.";
				#endregion

				#region Add subtitles to title
				title.Subtitles.AddRange(new List<Subtitle>
				{
					Subtitle_1("Глава 1. Метод void, return",
							   theory_1,
							   title),
					Subtitle_2("Глава 2. Сокращенная версия методов с результатом",
							   theory_2,
							   title),
					Subtitle_2("Глава 3. Выход из метода",
							   theory_3,
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
		private Subtitle Subtitle_3(string name, string theoryContent, Title title)
		{
			Subtitle subtitle = AddSubtitle(name, theoryContent, title);

			subtitle.TestList = TestList_3(subtitle);

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
			TestList testList = CreateTestList("Метод void, return: Тест", subtitle);

			testList.TestQuestions.Add(CreateQuestion("Какой оператор используется в методе для возврата значения?",
													  new string[] { "return", "void", "async" },
													  "return",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Какой тип используется в методе, который НЕ возвращает значение?",
													  new string[] { "return", "void", "async" },
													  "void",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Что будет возвращено при выполнении данного метода? \n" +
													  "string GetValue()\n" +
													  "{\n" +
													  "\treturn 3;\n" +
													  "}",
													  new string[] { "Число 3", "Строка \"3\"", "Ошибка" },
													  "Ошибка",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Что будет возвращено при выполнении данного метода? \n" +
													  "string GetValue()\n" +
													  "{\n" +
													  "\tint a = 5;\n" +
													  "\tint b = 0;\n" +
													  "\tfor(int i = 0; i == a; i++);\n" +
													  "\t{\n" +
													  "\t\tb += i;\n" +
													  "\t}\n" +
													  "\treturn b.toString();\n" +
													  "}",
													  new string[] { "Строка \"5\"", "Число 5", "Ошибка" },
													  "Строка \"5\"",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Что будет возвращено при выполнении данного метода? \n" +
													  "void GetValue()\n" +
													  "{\n" +
													  "\tConsole.WriteLine(\"Hello World!\")\n" +
													  "}",
													  new string[] { "Строка \"Hello World!\"", "Ошибка", "Ничего" },
													  "Ничего",
													  testList));

			return testList;
		}

		private TestList TestList_2(Subtitle subtitle)
		{
			TestList testList = CreateTestList("Сокращенная версия методов с результатом: Тест", subtitle);

			testList.TestQuestions.Add(CreateQuestion("Какая сокращенная версия данного метода?\n" +
												      "string GetValue()\n" +
												      "{\n" +
												      "\treturn \"Hello World!\";\n" +
												      "}",
													  new string[] { "void", "const", "if" },
													  "const",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Какая сокращенная версия данного метода?\n" +
													  "int GetValue(int x, int y)\n" +
													  "{\n" +
													  "\treturn x + y;\n" +
													  "}",
													  new string[] { "int GetValue(int x, int y) => x + y;", "int GetValue(int x, int y) => return x + y;", "Никакая" },
													  "int GetValue(int x, int y) => x + y;",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Что будет возвращено при выполнении данного метода? \n" +
													  "string GetValue()\n" +
													  "{\n" +
													  "\tstring value = \"Hello World!\";\n" +
													  "\treturn value;\n" +
													  "\tvalue = \"Hello World!!!\";\n" +
													  "}",
													  new string[] { "\"Hello World!\"", "\"Hello World!!!\"", "Ошибка" },
													  "\"Hello World!\"",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Что будет возвращено при выполнении данного кода? \n" +
													  "int GetValue(int x, int y) => x + y;\n" +
													  "\n" +
													  "GetValue();",
													  new string[] { "Сумма \"x\" и \"y\"", "Строка \"x\" + \"y\"", "Ошибка" },
													  "Ошибка",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Что будет возвращено при выполнении данного метода? \n" +
													  "int GetValue(int x, string y) => x + y;",
													  new string[] { "Сумма \"x\" и \"y\"", "Ошибка", "Ничего" },
													  "Ошибка",
													  testList));

			return testList;
		}
		private TestList TestList_3(Subtitle subtitle)
		{
			TestList testList = CreateTestList("Выход из метода: Тест", subtitle);

			testList.TestQuestions.Add(CreateQuestion("Что вернется при выполнении данного метода?\n" +
												      "void GetValue()\n" +
												      "{\n" +
												      "\treturn \"Hello World!\";\n" +
												      "}",
													  new string[] { "string GetValue() => \"Hello World!\";", "Ошибка", "Ничего" },
													  "Ошибка",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Что вернется при выполнении данного кода?\n" +
												      "string GetValue(int a, int b)\n" +
												      "{\n" +
												      "\tif (a > b)\n" +
												      "\t{\n" +
												      "\t\treturn \"a больше b\"\n" +
												      "\t}\n" +
												      "\telse if (a < b)\n" +
												      "\t{\n" +
												      "\t\treturn \"b больше a\"\n" +
												      "\t}\n" +
												      "}\n" +
												      "GetValue(1, 0)",
													  new string[] { "\"a больше b\"", "\"b больше a\"", "Ничего" },
													  "\"a больше b\"",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Что будет возвращено при выполнении данного метода? \n" +
													  "void GetValue(int x, int y) => x + y",
													  new string[] { "Сумма \"x\" и \"y\"", "Ничего", "Ошибка" },
													  "Ошибка",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Для чего используется тип void?",
													  new string[] { "Для возврата переменной", "Для определения того, что метод не возвращает значение", "Для проверки метода" },
													  "Для определения того, что метод не возвращает значение",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Для чего используется оператор return?",
													  new string[] { "Для определения того, что метод не возвращает значение", "Для завершения выполнения метода", "Для перехода на другое окно приложения" },
													  "Для завершения выполнения метода",
													  testList));

			return testList;
		}
		#endregion
	}
}
