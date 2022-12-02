using CSharpLearningApp.Classes;
using CSharpLearningApp.Models.PageModels.TestModels;
using CSharpLearningApp.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.PageData.Page_4
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
				Practice practice = null;

				title.Practice = practice; // Add practice to title
				#endregion

				#region Subtitles theory data
				string theory_1 = "Операции присвоения устанавливают значение. " +
								"В операциях присвоения участвуют два операнда, причем левый " +
								"операнд может представлять только модифицируемое именованное выражение, " +
								"например, переменную\r\n\r\nКак и во многих других языках программирования, в " +
								"C# имеется базовая операция присваивания =, которая присвоивает значение правого" +
								" операнда левому операнду: int number = 23. Здесь переменной number присваивается число 23." +
								" Переменная number представляет левый операнд, которому присваивается значение правого операнда," +
								" то есть числа 23.\r\n\r\nТакже можно выполнять множественно присвоение сразу нескольких переменным одновременно: int a, b, c," +
								"a = b = c 34. Сначала будет вычисляться выражение 34 * 2 / 4, затем полученное значение будет присвоено переменным.\r\n\r\nКроме базовой операции присвоения в C# есть еще ряд операций:\r\n\r\n+=: присваивание после сложения." +
								" Присваивает левому операнду сумму левого и правого операндов: выражение A += B равнозначно выражению A = A + B\r\n\r\n-=: присваивание после вычитания. Присваивает левому операнду разность левого и правого операндов: A -= B эквивалентно A = A - B\r\n\r\n*=: присваивание после умножения." +
								" Присваивает левому операнду произведение левого и правого операндов: A *= B эквивалентно A = A * B\r\n\r\n/=: присваивание после деления. Присваивает левому операнду частное левого и правого" +
								" операндов: A /= B эквивалентно A = A / B\r\n\r\n%=: присваивание после деления по модулю." +
								" Присваивает левому операнду остаток от целочисленного деления левого операнда на правый: A %= B эквивалентно A = A % B\r\n\r\n&=: присваивание после поразрядной конъюнкции. Присваивает левому" +
								" операнду результат поразрядной конъюнкции его битового представления с битовым представлением правого операнда:" +
								" A &= B эквивалентно A = A & B\r\n\r\n|=: присваивание после поразрядной дизъюнкции. Присваивает левому операнду результат поразрядной дизъюнкции его битового представления с битовым представлением" +
								" правого операнда: A |= B эквивалентно A = A | B\r\n\r\n^=: присваивание после операции исключающего ИЛИ." +
								" Присваивает левому операнду результат операции исключающего ИЛИ его битового представления с битовым представлением правого операнда: A ^= B эквивалентно A = A ^ B\r\n\r\n<<=: присваивание после сдвига разрядов влево. Присваивает левому операнду результат сдвига его битового представления влево на" +
								" определенное количество разрядов, равное значению правого операнда: A <<= B эквивалентно A = A << B\r\n\r\n>>=: присваивание после сдвига разрядов вправо. Присваивает левому операнду результат сдвига его битового представления вправо на определенное количество разрядов, равное значению правого операнда:" +
								" A >>= B эквивалентно A = A >> B ";

				string theory_2 = "Сначала будет вычисляться выражение 34 * 2 / 4, затем полученное значение будет присвоено переменным.\r\n\r\nКроме базовой операции присвоения в C# есть еще ряд операций:\r\n\r\n+=:" +
								" присваивание после сложения." +
								" Присваивает левому операнду сумму левого и правого операндов: выражение A += B" +
								" равнозначно выражению A = A + B\r\n\r\n-=: присваивание после вычитания. Присваивает левому операнду разность левого и правого операндов: A -= B эквивалентно A = A - B\r\n\r\n*=: присваивание после умножения." +
								" Присваивает левому операнду произведение левого и правого операндов: A *= B эквивалентно A = A * B\r\n\r\n/=:" +
								" присваивание после деления. Присваивает левому операнду частное левого и правого операндов: A /= B эквивалентно A = A / B\r\n\r\n%=: присваивание после деления по модулю." +
								" Присваивает левому операнду остаток от целочисленного деления левого операнда на правый: A %= B эквивалентно A = A % B\r\n\r\n&=: присваивание после поразрядной конъюнкции." +
								" Присваивает левому операнду результат поразрядной конъюнкции его битового представления с битовым представлением правого операнда: A &= B эквивалентно A = A & B\r\n\r\n";
				#endregion

				#region Add subtitles to title
				title.Subtitles.AddRange(new List<Subtitle>
				{
					Subtitle_1("Глава 1: Базовые операции",
							   theory_1,
							   title),
					Subtitle_2("Глава 2. Различные операции. Часть 1",
							   theory_2,
							   title),
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

			subtitle.TestList = null;

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
			TestList testList = CreateTestList("Базовые операции: Тест", subtitle);

			testList.TestQuestions.Add(CreateQuestion("Как обозначается базовая операция присваивания?",
													  new string[] { "=", "-=", "+=" },
													  "=",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Как обозначается дизъюнкция?",
													  new string[] { "*=", "%=", "|=" },
													  "|=",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Как обозначается присваивание после деления?",
													  new string[] { "/=", "-=", "|=" },
													  "|=",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Какое обозначение имеет присваивание после операции исключающего ИЛИ?",
													  new string[] { "=", "^=", "/=" },
													  "=",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Сколько операций присваивания существует?",
													  new string[] { "3", "5", "7" },
													  "3",
													  testList));

			return testList;
		}
		#endregion
	}
}
