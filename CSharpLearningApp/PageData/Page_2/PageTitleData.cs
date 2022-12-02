using CSharpLearningApp.Classes;
using CSharpLearningApp.Models.PageModels.TestModels;
using CSharpLearningApp.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.PageData.Page_2
{
	public class PageTitleData : PageDataBasic
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
					Task = "Напишите код, чтобы был следующий вывод: Имя: Tom, Возраст: 33, Вес: 78,68",
					CorrectAnswer = "Имя: Tom, Возраст: 33, Вес: 78,68",
					Title = title
				};
				#endregion

				title.Practice = practice; // Add practice to title

				#region Subtitles theory data
				string theory_1 = "bool: хранит значение true или false (логические литералы). Представлен системным типом System.Boolean \r" + "bool alive = true;\r\nbool isDead = false;\r\r" +
										"byte: хранит целое число от 0 до 255 и занимает 1 байт. Представлен системным типом System.Byte \r" + "byte bit1 = 1;\r\nbyte bit2 = 102;\r\r" +
										"sbyte: хранит целое число от -128 до 127 и занимает 1 байт. Представлен системным типом System.SByte\r" +
										"sbyte bit1 = -101;\r\nsbyte bit2 = 102;\r\n\r" +
										"short: хранит целое число от -32768 до 32767 и занимает 2 байта. Представлен системным типом System.Int16" +
										"\t\r\nbyte bit1 = 1;\r\nbyte bit2 = 102;" +
										"\r\r\nsbyte: хранит целое число от -128 до 127 и занимает 1 байт. Представлен системным типом System.SByte" +
										"\t\r\nsbyte bit1 = -101;\r\nsbyte bit2 = 102;\r\n" +
										"\r\n\rshort: хранит целое число от -32768 до 32767 и занимает 2 байта. Представлен системным типом System.Int16" +
										"\t\r\nshort n1 = 1;\r\nshort n2 = 102;\r\n" +
										"\r\n\rushort: хранит целое число от 0 до 65535 и занимает 2 байта. Представлен системным типом System.UInt16" +
										"\t\r\nushort n1 = 1;\r\nushort n2 = 102;" +
										"\r\r\nint: хранит целое число от -2147483648 до 2147483647 и занимает 4 байта. Представлен системным типом System.Int32. Все целочисленные литералы по умолчанию представляют значения типа int:" +
										"\t\r\nint a = 10;\r\nint b = 0b101;  // бинарная форма b =5\r\nint c = 0xFF;   // шестнадцатеричная форма c = 255\r\n" +
										"\r\r\nuint: хранит целое число от 0 до 4294967295 и занимает 4 байта. Представлен системным типом System.UInt32" +
										"\t\r\nuint a = 10;\r\nuint b = 0b101;\r\nuint c = 0xFF;" +
										"\r\r\nlong: хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт. Представлен системным типом System.Int64" +
										"\t\r\nlong a = -10;\r\nlong b = 0b101;\r\nlong c = 0xFF;" +
										"\r\n\rfloat: хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта. Представлен системным типом System.Single" +
										"\r\n\r\ndouble: хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта. Представлен системным типом System.Double" +
										"\r\n\r\ndecimal: хранит десятичное дробное число. Если употребляется без десятичной запятой, имеет значение от ±1.0*10-28 до ±7.9228*1028, может хранить 28 знаков после запятой и занимает 16 байт. Представлен системным типом System.Decimal" +
										"\r\n\r\nchar: хранит одиночный символ в кодировке Unicode и занимает 2 байта. Представлен системным типом System.Char. Этому типу соответствуют символьные литералы:" +
										"\t\r\nchar a = 'A';\r\nchar b = '\\x5A';\r\nchar c = '\\u0420';" +
										"\r\r\nstring: хранит набор символов Unicode. Представлен системным типом System.String. Этому типу соответствуют строковые литералы." +
										"\t\r\nstring hello = \"Hello\";\r\nstring word = \"world\";\r\n" +
										"\r\r\nobject: может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе. Представлен системным типом System.Object, который является базовым для всех других типов и классов .NET." +
										"\t\r\nobject a = 22;\r\nobject b = 3.14;\r\nobject c = \"hello code\";" +
										"\r\r\nНапример, определим несколько переменных разных типов и выведем их значения на консоль:" +
										"\t\r\nstring name = \"Tom\";\r\nint age = 33;\r\nbool isEmployed = false;\r\ndouble weight = 78.65;\r\nConsole.WriteLine($\"Имя: {name}\");\r\nConsole.WriteLine($\"Возраст: {age}\");\r\nConsole.WriteLine($\"Вес: {weight}\");\r\nConsole.WriteLine($\"Работает: {isEmployed}\");";

				string theory_2 = "Использование суффиксов" +
								"\rПри присвоении значений надо иметь в виду следующую тонкость: все вещественные литералы(дробные числа) рассматриваются как значения типа double.И чтобы указать, что дробное число представляет тип float или тип decimal, необходимо к литералу добавлять суффикс: F / f - для float и M / m - для decimal." +
								"\t\r\nfloat a = 3.14F;\r\nfloat b = 30.6f;\r\n \r\ndecimal c = 1005.8M;\r\ndecimal d = 334.8m;" +
								"\r\r\nПодобным образом все целочисленные литералы рассматриваются как значения типа int. Чтобы явным образом указать, что целочисленный литерал представляет значение типа uint, надо использовать суффикс U/u, для типа long - суффикс L/l, а для типа ulong - суффикс UL/ul:" +
								"\t\r\nuint a = 10U;\r\nlong b = 20L;\r\nulong c = 30UL;" +
								"\r\r\r\n Использование системных типов" +
								"\r\nВыше при перечислении всех базовых типов данных для каждого упоминался системный тип. Потому что название встроенного типа по сути представляет собой сокращенное обозначение системного типа. Например, следующие переменные будут эквивалентны по типу:" +
								"\t\r\nint a = 4;\r\nSystem.Int32 b = 4;";

				string theory_3 = "Ранее мы явным образом указывали тип переменных, например, int x;. И компилятор при запуске уже знал, что x хранит целочисленное значение." +
								"\r\n\r\nОднако мы можем использовать и модель неявной типизации:" +
								"\t\r\nvar hello = \"Hell to World\";\r\nvar c = 20;" +
								"\r\r\nДля неявной типизации вместо названия типа данных используется ключевое слово var. Затем уже при компиляции компилятор сам выводит тип данных исходя из присвоенного значения. Так как по умолчанию все" +
								" целочисленные значения рассматриваются как значения типа int, то поэтому в итоге переменная c будет иметь тип int. Аналогично переменной hello присваивается строка, поэтому эта переменная будет иметь тип string" +
								"\r\n\r\nЭти переменные подобны обычным, однако они имеют некоторые ограничения.\r\n\r\nВо-первых, мы не можем сначала объявить неявно типизируемую переменную, а затем инициализировать:" +
								"\t\r\n// этот код работает\r\nint a;\r\na = 20;\r\n \r\n// этот код не работает\r\nvar c;\r\nc= 20;" +
								"\r\r\nВо-вторых, мы не можем указать в качестве значения неявно типизируемой переменной null:" +
								"\t\r\n// этот код не работает\r\nvar c=null;" +
								"\r\nТак как значение null, то компилятор не сможет вывести тип данных."; 
				#endregion

				#region Add subtitles to title
				title.Subtitles.AddRange(new List<Subtitle>
				{
					Subtitle_1("Глава 1: Базовые типы данных",
							   theory_1,
							   title),
					Subtitle_2("Глава 2. Использование суффиксов и системных типов",
							   theory_2,
							   title),
					Subtitle_3("Глава 3. Неявная типизация",
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
			TestList testList = CreateTestList("Базовые типы данных: Тест", subtitle);

			testList.TestQuestions.Add(CreateQuestion("Какой тип данных хранит целое число от 0 до 4294967295 и занимает 4 байта?",
													  new string[] { "float", "int", "uint" },
													  "uint",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Каким системным типом представлен short?",
													  new string[] { "System.Int16", "System.UInt32", "System.UInt64" },
													  "System.Int16",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Какой из перечисленных типов данных, представлен системным типом System.Int64?",
													  new string[] { "long", "char", "int" },
													  "long",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Какой из перечисленных типов данных, может хранить значение любого типа данных?",
													  new string[] { "string", "object", "byte" },
													  "object",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("double хранит:",
													  new string[] { "десятичное дробное число", "число с плавающей точкой", "одиночный символ" },
													  "число с плавающей точкой",
													  testList));

			return testList;
		}

		private TestList TestList_2(Subtitle subtitle)
		{
			TestList testList = CreateTestList("Использование суффиксов и системных типов: Тест", subtitle);

			testList.TestQuestions.Add(CreateQuestion("Все вещественные литералы (дробные числа) рассматриваются как значения типа:",
													  new string[] { "double", "int", "float" },
													  "double",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Какие литералы рассматриваются как значения типа int?",
													  new string[] { "строковые", "логические", "целочисленные" },
													  "целочисленные",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Все целочисленные литералы рассматриваются как значения типа:",
													  new string[] { "long", "string", "int" },
													  "int",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Какой суффикс необходимо добавить к литералу, чтобы указать что число представляет тип float?",
													  new string[] { "F/f", "UL/ul", "L/l" },
													  "F/f",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Название какого типа по сути представляет собой сокращенное обозначение системного типа?",
													  new string[] { "штатного", "встроенного", "отдельного" },
													  "встроенного",
													  testList));

			return testList;
		}

		private TestList TestList_3(Subtitle subtitle)
		{
			TestList testList = CreateTestList("Неявная типизация: Тест", subtitle);

			testList.TestQuestions.Add(CreateQuestion("Какое ключевое слово используется для неявной типизации вместо названия типа данных?",
													  new string[] { "char", "var", "uint" },
													  "var",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("var hello = \"Hell to World\";\nvar c = 20;\n Это пример использования:",
													  new string[] { "Неявной типизации", "Системных типов", "Суффиксов" },
													  "Неявной типизации",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Возможно ли сначала объявить неявно типизируемую переменную, а затем инициализировать?",
													  new string[] { "Возможно", "Невозможно" },
													  "Невозможно",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Работает ли этот код?: var c = null;",
													  new string[] { "Работает", "Не работает" },
													  "Не работает",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Что будет при выполнении кода?:\nvar c;\nc = 20;",
													  new string[] { "\"c\" присвоит значение 20", "Выведится 20", "Произойдет ошибка" },
													  "Произойдет ошибка",
													  testList));

			return testList;
		}
		#endregion
	}
}
