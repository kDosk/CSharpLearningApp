using CSharpLearningApp.Classes;
using CSharpLearningApp.Models.PageModels.TestModels;
using CSharpLearningApp.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.PageData.Page_3
{
	internal class PageTitleData : PageDataBasic
	{
		public void AddData(string titleName)
		{
			var context = ApplicationContext.GetContext();
			if (!context.Titles.ToList().Exists(p => p.Name == titleName))
			{
				Title title = new Title { Name = titleName, TitleCreator = "Л. Нияз" }; // Create title

				#region Create Practice
				Practice practice = new Practice
				{
					Task = "Выполните сложение двух чисел: a = 0.5, b = 5.7",
					CorrectAnswer = "6,2",
					Title = title
				};
				#endregion

				title.Practice = practice; // Add practice to title

				#region Subtitles theory data
				string theory_1 = "В C# используется большинство операций, которые применяются и в других языках программирования. Операции представляют определенные действия над операндами - участниками операции. В качестве операнда может выступать переменной или какое-либо значение (например, число). Операции бывают унарными (выполняются над одним операндом), бинарными - над двумя операндами и тернарными - выполняются над тремя операндами. Рассмотрим все виды операций.\n" +
								"+ операция сложения двух чисел\n" +
								"int x = 10;                   int z = x + 12; // 22\n" +
								"- операция вычитания двух чисел\n" +
								"int x = 10;                   int z = x - 6; // 4\n" +
								"* операция умножения двух чисел\n" +
								"int x = 10;                   int z = x * 5; // 50\n" +
								"/ операция деления двухчисел\n" +
								"int x = 10;     int z = x / 5; // 2     double a = 10;    double b = 3;  double c = a / b; // 3.33333333\n" +
								"% Операция получение остатка от целочисленного деления двух чисел:\n" +
								"double x = 10.0;             double z = x % 4.0; //результат равен 2";

				string theory_2 = "++ Операция инкремента Инкремент бывает префиксным: ++x - сначала значение переменной x увеличивается на 1, а потом ее значение возвращается в качестве результата операции. И также существует постфиксный инкремент: x++ - сначала значение переменной x возвращается в качестве результата операции, а затем к нему прибавляется 1.\n" +
								"int x1 = 5; int z1 = ++x1; // z1=6; x1=6 Console.WriteLine($\"{x1} - {z1}\"); int x2 = 5; int z2 = x2++; // z2=5; x2=6  Console.WriteLine($\"{x2} - {z2}\");\n" +
								"Операция декремента или уменьшения значения на единицу. Также существует префиксная форма декремента (--x) и постфиксная (x--).\n" +
								"int x1 = 5; int z1 = --x1; // z1=4; x1=4 Console.WriteLine($\"{x1} - {z1}\"); int x2 = 5; int z2 = x2--; // z2=5; x2=4  Console.WriteLine($\"{x2} - {z2}\");\n" +
								"При выполнении сразу нескольких арифметических операций следует учитывать порядок их выполнения. Приоритет операций от наивысшего к низшему: 1. Инкремент, декремент 2. Умножение, деление, получение остатка 3. Сложение, вычитание\n" +
								"Для изменения порядка следования операций применяются скобки. Рассмотрим набор операций:\n" +
								"int a = 3; int b = 5; int c = 40; int d = c---b*a;    // a=3  b=5  c=39  d=25  Console.WriteLine($\"a={a}  b={b}  c={c}  d={d}\");\n" +
								"Здесь мы имеем дело с тремя операциями: декремент, вычитание и умножение. Сначала выполняется декремент переменной c, затем умножение b*a, и в конце вычитание. То есть фактически набор операций выглядел так:\n" +
								"int d = (c--)-(b*a);";

				string theory_3 = "Как выше было отмечено, операции умножения и деления имеют один и тот же приоритет, но какой тогда результат будет в выражении:\n" +
								"int x = 10 / 5 * 2;\n" +
								"Стоит нам трактовать это выражение как (10 / 5) * 2 или как 10 / (5 * 2)? Ведь в зависимости от трактовки мы получим разные результаты.\n" +
								"Когда операции имеют один и тот же приоритет, порядок вычисления определяется ассоциативностью операторов. В зависимости от ассоциативности есть два типа операторов:\n" +
								"- Левоассоциативные операторы, которые выполняются слева направо\n" +
								"- Правоассоциативные операторы, которые выполняются справа налево\n" +
								"Все арифметические операторы являются левоассоциативными, то есть выполняются слева направо. Поэтому выражение 10 / 5 * 2 необходимо трактовать как (10 / 5) * 2, то есть результатом будет 4.";
				#endregion

				#region Add subtitles to title
				title.Subtitles.AddRange(new List<Subtitle>
				{
					Subtitle_1("Глава 1: Бинарные операции",
							   theory_1,
							   title),
					Subtitle_2("Глава 2. Унарные операции",
							   theory_2,
							   title),
					Subtitle_3("Глава 3. Ассоциативность операторов",
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
			TestList testList = CreateTestList("Бинарные операции: Тест", subtitle);

			testList.TestQuestions.Add(CreateQuestion("Что может выступать в качестве операнда?",
													  new string[] { "Человек", "Буква", "Число" },
													  "Число",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("int x = 10;\nint z = x + 12;\nэто операция ...",
													  new string[] { "Умножения", "Вычитания", "Сложения" },
													  "Сложения",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Какие операции выполняются над одним операндом?",
													  new string[] { "Унарные", "Бинарные", "Тринарные" },
													  "Унарные",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("double z = 10 /  4;\nОтвет будет равен:",
													  new string[] { "2,5", "2", "2.5" },
													  "2",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Будет ли результат округляться до целого числа если оба операнда будут целыми числами?",
													  new string[] { "Округлятся", "Будут с остатком", "Округлятся до десятых" },
													  "Округлятся",
													  testList));

			return testList;
		}

		private TestList TestList_2(Subtitle subtitle)
		{
			TestList testList = CreateTestList("Унарные операции: Тест", subtitle);

			testList.TestQuestions.Add(CreateQuestion("Сколько опернадов принимают участие в унарных операциях?",
													  new string[] { "Один", "два", "Три" },
													  "Один",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Что применяют для изменения порядка операции?",
													  new string[] { "Скобки", "Расположение", "молитву" },
													  "Скобки",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Какими бывают инкременты?",
													  new string[] { "Префиксным", "Фиксированным", "Свободным" },
													  "Префиксным",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Какие формы декремента существуют?",
													  new string[] { "Постфиксная", "Фиксированная", "Свободная" },
													  "Постфиксная",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("При выполнении сразу нескольких арифметических операций кто имеет наивысший приоритет?",
													  new string[] { "Умножение", "Сложение", "Инкремент" },
													  "Инкремент",
													  testList));

			return testList;
		}

		private TestList TestList_3(Subtitle subtitle)
		{
			TestList testList = CreateTestList("Ассоциативность операторов: Тест", subtitle);

			testList.TestQuestions.Add(CreateQuestion("int x = 10 / 5 * 2;\nЧему равен \"x\"",
													  new string[] { "1", "4", "2" },
													  "4",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Какие бывают типы операторов?",
													  new string[] { "Левоассоциативные", "Среднеассоциативные", "Не ассоциативные" },
													  "Левоассоциативные",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Какими являются все операторы?",
													  new string[] { "Левоассоциативные", "Правоассоциотивные", "Целыми" },
													  "Левоассоциативные",
													  testList));

			return testList;
		}
		#endregion
	}
}
