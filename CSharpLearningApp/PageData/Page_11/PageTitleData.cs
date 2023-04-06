using CSharpLearningApp.Classes;
using CSharpLearningApp.Models.PageModels.TestModels;
using CSharpLearningApp.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.PageData.Page_11
{
	public class PageTitleData : PageDataBasic
	{
		public void AddData(string titleName)
		{
			var context = ApplicationContext.GetContext();
			if (!context.Titles.ToList().Exists(p => p.Name == titleName))
			{
				Title title = new Title { Name = titleName, TitleCreator = "C. Регина" }; // Create title

				#region Create Practice
				Practice practice = null;
				#endregion

				title.Practice = practice; // Add practice to title

				#region subtitles theory
				string theory_1 = "Перечисление ENUM." +
								  " Первая часть  Тип перечисления в программировании, представляет собой ограниченный список идентификаторов." +
								  "Тип перечисления в программировании, представляет собой ограниченный список идентификаторов." +
								  " Использование перечислений позволяет сделать исходные коды программ более читаемыми" +
								  " Когда тип перечисление экспортируется модулем -  нарушается общее правило экспортирует одновременно все его элементы, тогда как для всех остальных типов экспорт типа скрывает его внутреннюю структуру; " +
								  " Ещё одна возможность, которую дают перечисляемые типы на уровне реализации языка — экономия памяти." +
								  " Формат хранения и диапазон возможных значений перечисляемого типа определяются его базовым типом." +
								  " Вершины одного типа не могут быть соединены непосредственно." +
								  " Каждое перечисление фактически определяет новый тип данных, с помощью которых мы также, как и с помощью любого другого типа, можем определять переменные, константы, параметры методов и т.д" +
								  " Перечисление на языке C++ наследует поведение перечислений языка C, и ключевое слово enum используется только при объявлений такого типа" +
								  " Главным отличием является то,что используя enum можно проверить тип данных. И передать классу любое значение int";

				string theory_2 = "Хранилище enum" +
								" Зачастую переменная перечисления выступает в качестве хранилища состояния." +
								" Уплотнение записей при обработке больших их количеств может освободить много памяти." +
								" Хранилище перечисляемых типов должно относиться к типу Int" +
								" В enum надо помещать действительно незыблемые и фундаментальные вещи, которые не меняются годами, а не гендеры, которые добавляются и исчезают каждый релиз!";
				string theory_3 = "Константы Enum" +
							   " Константа переменная значение которой не меняется во время работы программы." +
							   " Константы используются для борьбы с Магическими числами, т.е. непонятно что означающими числами или строками." +
							   " В Java нет специальной директивы для объявления констант как например const в Pascal/Delphi или в C/C++ " +
							   " Не указывайте перечисляемые константы, зарезервированные для использования в будущем." +
							   " Eсли не определить константу, значение которой равно нулю, перечисление будет содержать недопустимое значение при его создании." +
							   " При создании перечисления нельзя определить новые методы. Однако тип перечисления наследует полный набор статических и экземплярных методов от Enum класса." +
							   " Методы Parse и TryParse методы позволяют преобразовать строковое представление значения перечисления в это значение. Строковое представление может быть либо именем, либо базовым значением константы перечисления." +
							   " Можно использовать методы расширения для добавления функциональных возможностей в определенный тип перечисления.";
				#endregion

				#region Add subtitles to title
				title.Subtitles.AddRange(new List<Subtitle>
				{
					Subtitle_1("Глава 1. Перечисление ENUM",
							   theory_1,
							   title),
					Subtitle_2("Глава 2. Хранилище enum",
							   theory_2,
							   title),
					Subtitle_3("Глава 2. Константы Enum",
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
			TestList testList = CreateTestList("Перечисление ENUM: Тест", subtitle);

			testList.TestQuestions.Add(CreateQuestion("Что такое enum?",
													  new string[] { "представляет собой ограниченный список идентификаторов.", "содержит тип для перечисления значений", "int32" },
													  "представляет собой ограниченный список идентификаторов.",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Для чего нужны перечисления?",
													  new string[] { "Содержит тип для перечисления значений", "Позволяет создовать переменную которая может принимать несколько значений", "int32" },
													  "Позволяет создовать переменную которая может принимать несколько значений",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Для чего нужен enum?",
													  new string[] { "Cодержит в себе тип для перечисления значений с возможностью итерирования и сравнения", "Int", "Содержит информацию" },
													  "Cодержит в себе тип для перечисления значений с возможностью итерирования и сравнения",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Почему ENUM нельзя наследовать?",
													  new string[] { "Java не поддерживает множественное наследование классов", "Java поддерживает множественное наследование классов", "Int" },
													  "Java не поддерживает множественное наследование классов",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Что делает enum?",
													  new string[] { "Не позволяет переменной быть набором предопределенных констант", "Позволяет переменной быть набором предопределенных констант", "Int" },
													  "Позволяет переменной быть набором предопределенных констант",
													  testList));

			return testList;
		}

		private TestList TestList_2(Subtitle subtitle)
		{
			TestList testList = CreateTestList("Хранилище enum: Тест", subtitle);

			testList.TestQuestions.Add(CreateQuestion("Что используется для хранения?",
													  new string[] { "Для хранения значений констант используется тип данных System.Int32", "Содержит тип для перечисления значений", "Упрощают работу" },
													  "Для хранения значений констант используется тип данных System.Int32",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Какие типы могут быть использованы в качестве значений перечисления?",
													  new string[] { "byte, sbyte", "Тип перечисления обязательно должен представлять целочисленный тип", "Перечисление и ничего более" },
													  "Тип перечисления обязательно должен представлять целочисленный тип",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Можно ли создать enum без экземпляров объектов?",
													  new string[] { "Да, вы можете создать Enum без экземпляров", "Несколько раз", "Не можете" },
													  "Да, вы можете создать Enum без экземпляров",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Когда нужно использовать ENUM?",
													  new string[] { "когда в  программе ошибка", "когда нужно определенное значение", "когда нужно конечное, заранее определенное, адекватно именованное множество уникальных значений" },
													  "когда нужно конечное, заранее определенное, адекватно именованное множество уникальных значений",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Метод PrintMessage()",
													  new string[] { "Выполняет перечисление", "Изменяет значение", "Принимает значение типа перечисления DayTime" },
													  "Принимает значение типа перечисления DayTime",
													  testList));

			return testList;
		}

		private TestList TestList_3(Subtitle subtitle)
		{
			TestList testList = CreateTestList("Константы enum: Тест", subtitle);

			testList.TestQuestions.Add(CreateQuestion("Что такое константа?",
													  new string[] { "оба ответа верны", "переменная значение которой не меняется во время работы программы", "ограниченная последовательность символов алфавита языка" },
													  "оба ответа верны",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Константы бывают?",
													  new string[] { "бывают программные", "бывают числовые, символьные и строковые", "бывают буквенные" },
													  "бывают числовые, символьные и строковые",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Константы используются для?",
													  new string[] { "используются для борьбы с Магическими числами или строками", "для борьбы с вирусами", "оба ответа верны" },
													  "используются для борьбы с Магическими числами или строками",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("От чего зависеть магическое число?",
													  new string[] { "от перечисления связанных констант", "исходный код программы", "от неявного параметра или другого магического числа" },
													  "от неявного параметра или другого магического числа",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("В чем преимущество enum?",
													  new string[] { "вы можете передать в класс любое значение int", "оба ответа верны", "используя enum вы можете проверить тип данных" },
													  "Апострофы",
													  testList));

			return testList;
		}
		#endregion
	}
}
