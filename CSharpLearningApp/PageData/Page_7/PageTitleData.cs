﻿using CSharpLearningApp.Classes;
using CSharpLearningApp.Models.PageModels.TestModels;
using CSharpLearningApp.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.PageData.Page_7
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
				#endregion

				title.Practice = practice; // Add practice to title

				#region Subtitles theory data
				string theory_1 = "Цикл for. " +
								"Объявление цикла for состоит из трех частей. Первая часть объявления цикла - некоторые действия, которые выполняются один раз до выполнения цикла. Обычно здесь определяются переменные, которые будут использоваться в цикле. " +
								"Вторая часть - условие, при котором будет выполняться цикл. Пока условие равно true, будет выполняться цикл." +
								"И третья часть - некоторые действия, которые выполняются после завершения блока цикла. Эти действия выполняются каждый раз при завершении блока цикла." +
								"После объявления цикла в фигурных скобках помещаются сами действия цикла." +
								"Цикл for в C# предоставляет механизм итерации, в котором определенное условие проверяется перед выполнением каждой итерации." +
								"Синтаксис этого оператора показан ниже:" +
								"for (инициализатор; условие; итератор) оператор (операторы);" +
								"Здесь:" +
								"инициализатор — это выражение, вычисляемое перед первым выполнением тела цикла (обычно инициализация локальной переменной в качестве счетчика цикла). " +
								"Инициализация, как правило, представлена оператором присваивания, задающим первоначальное значение переменной, которая исполняет роль счетчика и управляет циклом;" +
								"условие — это выражение, проверяемое перед каждой новой итерацией цикла (должно возвращать true, чтобы была выполнена следующая итерация);" +
								"итератор – это выражение, вычисляемое после каждой итерации (обычно приращение значения счетчика цикла)." +
								"Цикл foreach предназначен для перебора набора или коллекции элементов." +
								"Оператор цикла foreach действует следующим образом." +
								"Когда цикл начинается, первый элемент массива выбирается и присваивается переменной цикла." +
								"На каждом последующем шаге итерации выбирается следующий элемент массива, который сохраняется в переменной цикла." +
								"Цикл завершается, когда все элементы массива окажутся выбранными." +
								"Цикл foreach позволяет проходить по каждому элементу коллекции (объект, представляющий список других объектов). ";

				string theory_2 = "Цикл do...while в C# — это версия while с постпроверкой условия. Это значит, что условие цикла проверяется после выполнения тела цикла. Цикл do...while продолжается до тех пор, пока не будет выполнено заданное условие. Его также называют циклом с постусловием. Он используется, когда необходимо выполнить цикл хотя бы один раз. " +
								" Оператор do выполняет оператор или блок операторов, пока определенное логическое выражение равно значению true. " +
								" Так как это выражение оценивается после каждого выполнения цикла, цикл do выполняется один или несколько раз. " +
								" Это отличает его от цикла while, который выполняется от нуля до нескольких раз." +
								 " Как работает?" +
								" Выполняется тело цикла do...while " +
								" Проверяется условие. Если условие оценивается как true, то выполняется тело цикла." +
								" Цикл завершается, если условие оценивается как false." +
								" Цикл while" +
								" в отличие от цикла do сразу проверяет истинность некоторого условия, и если условие истинно, то код цикла выполняется:" +
								" Цикл while используется в сценарии, когда мы не знаем заранее количество итераций. Блок операторов в цикле while выполняется до тех пор, пока не будет выполнено условие, указанное в цикле while. Его также называют циклом с предварительной проверкой условия." +
								" Как работает?" +
								" Оператор do выполняет оператор или блок операторов, пока определенное логическое выражение равно значение true. " +
								" Так как это выражение оценивается после каждого выполнения цикла, цикл do выполняется один или несколько раз." +
								" Это отличает его от цикла while, который выполняется от нуля до нескольких раз." +
								" while (условие) оператор (операторы):" +
								" где оператор — это единственный оператор или же блок операторов, " +
								" а условие означает конкретное условие управления циклом и может быть любым логическим выражением." +
								" Если условие цикла while или do...while никогда не станет равно false, то цикл будет выполняться бесконечно. " +
								" Такие циклы называются бесконечными. " +
								" Чтобы не получить бесконечного цикла, необходимо изменять параметр, проверяемый в условии. ";

				string theory_3 = "В структурном программировании признаются полезными переходы вперед (но не назад), позволяющие при выполнении некоторого условия выйти из цикла, из оператора выбора, из блока. " +
								" Для этой цели можно использовать оператор goto, но лучше применять специально предназначенные для этих целей операторы break и continue." +
								" Однократное выполнение блока цикла называется итерацией." +
								" Операторы continue/break с меткой используются в том случае, если в программе присутствуют вложенные циклы. " +
								" При этом break с меткой обеспечивает полный выход изо всех вложенных циклов." +
								" А continue с меткой выходит из текущего вложенного цикла с последующим переходом к очередной итерации внешнего цикла. " +
								" Оператор break применяется для прерывания текущей итерации (break (broke, broken) — ломать, разрывать). " +
								" С его помощью происходит выход из блока фигурных скобок оператора цикла либо оператора switch с дальнейшей передачей управления следующему оператору." +
								" Если задействуются вложенные операторы, break обеспечивает выход из самого внутреннего оператора." +
								" А что если мы хотим, чтобы при проверке цикл не завершался, а просто пропускал текущую итерацию. " +
								" Для этого мы можем воспользоваться оператором continue " +
								" Оператор continue предназначен для перехода к выполнению следующей итерации цикла. " +
								" Если в теле цикла встречается оператор continue, " +
								" то: выполнение текущей итерации останавливается происходит переход к следующей итерации цикла" +
								" Оператор continue осуществляет принудительный переход к следующему шагу цикла, пропуская любой код, оставшийся невыполненным. " +
								" Таким образом, оператор continue служит своего рода дополнением оператора break." +
								" Вложенные циклы – это циклы, организованные в теле другого цикла. " +
								" Вложенный цикл в тело другого цикла, называется внутренним циклом. " +
								" Цикл, в теле которого существует вложенный цикл, называется внешним.";
				#endregion

				#region Add subtitles to title
				title.Subtitles.AddRange(new List<Subtitle>
				{
					Subtitle_1("Глава 1: Циклы for, foreach",
							   theory_1,
							   title),
					Subtitle_2("Глава 2. Циклы do...while, while",
							   theory_2,
							   title),
					Subtitle_3("Глава 3. Команды continue и break",
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
			TestList testList = CreateTestList("Циклы for, foreach: Тест", subtitle);

			testList.TestQuestions.Add(CreateQuestion("Выберите первую часть объявления цикла for:",
													  new string[] { "Действия выполняются один раз до выполнения цикла.", "Условие, при котором будет выполняться цикл.", "Определённая часть" },
													  "Действия выполняются один раз до выполнения цикла.",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Выберите вторую часть объявления цикла for:",
													  new string[] { "Действия выполняются один раз до выполнения цикла.", "Условие, при котором будет выполняться цикл.", "Неопределённая часть." },
													  "Условие, при котором будет выполняться цикл.",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Выберите третью часть объявления цикла for:",
													  new string[] { "Действия выполняются после завершения блока цикла", "Действия выполняются в середине работы с циклом", "Действия выполняются в начале блока цикла", "Оба не верны" },
													  "Действия выполняются после завершения блока цикла",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Что такое итерация в цикле for?",
													  new string[] { "Однократное выполнение блока цикла", "Повторное применение какой-либо математической операции", "Удвоение одного символа" },
													  "Однократное выполнение блока цикла",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Для чего предназначен цикл foreach?",
													  new string[] { "Тело цикла должно быть выполнено хотя бы один раз",
																	 "Для перебора набора или коллекции элементов",
																	 "Чтобы повторять выполнение оператора" },
													  "Для перебора набора или коллекции элементов",
													  testList));

			return testList;
		}

		private TestList TestList_2(Subtitle subtitle)
		{
			TestList testList = CreateTestList("Циклы do...while, while: Тест", subtitle);

			testList.TestQuestions.Add(CreateQuestion("Цикл do...while - это...",
													  new string[] { "Версия while с постпроверкой условия", "Версия for с проверкой условия", "Версия while с for" },
													  "Версия while с постпроверкой условия",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Цикл do...while, это цикл с...",
													  new string[] { "Цикл с предварительной проверкой условия", "Цикл с постусловием", "Цикл с предусловием" },
													  "Цикл с постусловием",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Цикл do...while выполняется...",
													  new string[] { "один или несколько раз", "от нуля до несколько раз", "пока численный счётчик меньше 3" },
													  "один или несколько раз",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Цикл является бесконечным,если...",
													  new string[] { "условие цикла никогда не станет = true", "условие цикла выполняется", "условие цикла никогда не станет = false" },
													  "условие цикла никогда не станет = false",
													  testList));
			testList.TestQuestions.Add(CreateQuestion("Что сделать, чтобы не получить бесконечный цикл?",
													  new string[] { "изменить название цикла", "изменить условие", "изменять параметр, проверяемый в условии" },
													  "изменять параметр, проверяемый в условии",
													  testList));

			return testList;
		}
		#endregion
	}
}