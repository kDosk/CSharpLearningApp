using CSharpLearningApp.Classes;
using CSharpLearningApp.Models.PageModels.TestModels;
using CSharpLearningApp.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.PageData.Page_6
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
                    Task = "Выведите результат сравнения двух чисел: 0.5 == 5.7",
                    CorrectAnswer = "false",
                    Title = title
                };
                #endregion

                title.Practice = practice; // Add practice to title

                #region Subtitles theory data
                string theory_1 = " Отдельный набор операций представляет условные выражения. " +
                                "Такие операции возвращают логическое значение, то есть значение типа bool: true, если выражение истинно, и false, если выражение ложно. " +
                                "К подобным операциям относятся операции сравнения и логические операции. Условные конструкции могут включать в себя:" +
                                "\r\n\r\nОперации сравнения – это отдельная группа операторов, для сравнения значений, на вход принимают два аргумента одинакового типа данных, " +
                                "а возвращают логическое значение true(истина) или false(ложь);\r\nЛогические операции – операторы, которые используются для работы " +
                                "с логическим типом данных bool (название в .Net нотации System.Boolean).";

                string theory_2 = "В операциях сравнения сравниваются два операнда и возвращается значение типа bool - true, " +
                                "если выражение верно, и false, если выражение неверно. \r\n\r==\r\nСравнивает два операнда " +
                                "на равенство. Если они равны, то операция возвращает true, если не равны, то " +
                                "возвращается false:\r\nint a = 10;\r\nint b = 4;\r\nbool c = " +
                                "a == b; // false \r\n\r!=\r\nСравнивает два операнда и возвращает " +
                                "true, если операнды не равны, и false, если они равны.\r\nint a = 10;\r\nint b = 4;\r\nbool c = a != b;    " +
                                "// true\r\nbool d = a!=10;     // false\r\n\r<\r\nОперация \"меньше чем\". Возвращает true, " +
                                "если первый операнд меньше второго, и false, если первый операнд больше второго:" +
                                "\r\nint a = 10;\r\nint b = 4;\r\nbool c = a < b; // false\r\n\r>\r\nОперация \"больше чем\". " +
                                "Сравнивает два операнда и возвращает true, если первый операнд больше второго, иначе возвращает false:" +
                                "\r\nint a = 10;\r\nint b = 4;\r\nbool c = a > b;     // true\r\nbool d = a > 25;    // false\r\n\r<=\r\nОперация " +
                                "\"меньше или равно\". Сравнивает два операнда и возвращает true, если первый операнд меньше или равен второму. " +
                                "Иначе возвращает false.\r\nint a = 10;\r\nint b = 4;\r\nbool c = a <= b;   " +
                                "// false\r\nbool d = a <= 25;    // true\r\n\r>=\r\nОперация \"больше или равно\". Сравнивает два операнда и " +
                                "возвращает true, если первый операнд больше или равен второму, иначе возвращается false:\r\nint a = 10;\r\nint b = 4;" +
                                "\r\nbool c = a >= b;     // true\r\nbool d = a >= 25;    // false\r\nОперации <, > <=, >= имеют больший приоритет, чем == и !=.";

                string theory_3 = "Также в C# определены логические операторы, которые также возвращают значение типа bool." +
                                " В качестве операндов они принимают значения типа bool. Как правило, применяются к отношениям и объединяют несколько операций сравнения." +
                                "\r\n\r\n|\r\nОперация логического сложения или логическое ИЛИ. Возвращает true, если хотя бы один из операндов возвращает true." +
                                "\r\nbool x1 = (5 > 6) | (4 < 6); // 5 > 6 - false, 4 < 6 - true, " +
                                "поэтому возвращается true\r\nbool x2 = (5 > 6) | (4 > 6); // 5 > 6 - false, 4 > 6 - false, поэтому возвращается false" +
                                "\r\n\r&\r\nОперация логического умножения или логическое И. Возвращает true, если оба операнда одновременно равны true." +
                                "\r\nbool x1 = (5 > 6) & (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается false" +
                                "\r\nbool x2 = (5 < 6) & (4 < 6); // 5 < 6 - true, 4 < 6 - true, поэтому возвращается true" +
                                "\r\n\r\n||\r\nОперация логического сложения. Возвращает true, если хотя бы один из операндов возвращает true." +
                                "\r\nbool x1 = (5 > 6) || (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true" +
                                "\r\nbool x2 = (5 > 6) || (4 > 6); // 5 > 6 - false, 4 > 6 - false, поэтому возвращается false" +
                                "\r\n\r\n&&\r\nОперация логического умножения. Возвращает true, если оба операнда одновременно равны true." +
                                "\r\nbool x1 = (5 > 6) && (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается false" +
                                "\r\nbool x2 = (5 < 6) && (4 < 6); // 5 < 6 - true, 4 < 6 - true, поэтому возвращается true" +
                                "\r\n\r\n!\r\nОперация логического отрицания. Производится над одним операндом и возвращает true, если операнд равен false. " +
                                "Если операнд равен true, то операция возвращает false:\r\nbool a = true;\r\nbool b = !a;    // false" +
                                "\r\n\r^\r\nОперация исключающего ИЛИ. Возвращает true, если либо первый, либо второй операнд (но не одновременно) равны true, " +
                                "иначе возвращает false\r\nbool x5 = (5 > 6) ^ (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true" +
                                "\r\nbool x6 = (50 > 6) ^ (4 / 2 < 3); // 50 > 6 - true, 4/2 < 3 - true, поэтому возвращается false" +
                                "\r\nЗдесь у нас две пары операций | и || (а также & и &&) выполняют похожие действия, однако же они не равнозначны." +
                                "\r\n\r\nВ выражении z=x|y; будут вычисляться оба значения - x и y.\r\n\r\nВ выражении же z=x||y; сначала будет вычисляться значение x, " +
                                "и если оно равно true, то вычисление значения y уже смысла не имеет, так как у нас в любом случае уже z будет равно true. " +
                                "Значение y будет вычисляться только в том случае, если x равно false\r\n\r\nТо же самое касается пары операций &/&&. " +
                                "В выражении z=x&y; будут вычисляться оба значения - x и y.\r\n\r\nВ выражении же z=x&&y; " +
                                "сначала будет вычисляться значение x, и если оно равно false, то вычисление значения y уже смысла не имеет, " +
                                "так как у нас в любом случае уже z будет равно false. Значение y будет вычисляться только в том случае, если x равно true" +
                                "\r\n\r\nПоэтому операции || и && более удобны в вычислениях, так как позволяют сократить время на вычисление значения выражения, " +
                                "и тем самым повышают производительность. А операции | и & больше подходят для выполнения поразрядных операций над числами.";
                #endregion

                #region Add subtitles to title
                title.Subtitles.AddRange(new List<Subtitle>
                {
                    Subtitle_1("Глава 1: Основные понятия",
                               theory_1,
                               title),
                    Subtitle_2("Глава 2. Операции сравнения",
                               theory_2,
                               title),
                    Subtitle_3("Глава 3. Логические операции",
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
            TestList testList = CreateTestList("Основные понятия: Тест", subtitle);

            testList.TestQuestions.Add(CreateQuestion("Какой тип данных возвращает логические операции?",
                                                      new string[] { "bool", "string", "int" },
                                                      "bool",
                                                      testList));
            testList.TestQuestions.Add(CreateQuestion("Какие значение принимает bool?",
                                                      new string[] { "true", "false", "Оба" },
                                                      "Оба",
                                                      testList));
            testList.TestQuestions.Add(CreateQuestion("Что в себя включают условные конструкции?",
                                                      new string[] { "Операции сравнения", "Логические операции", "Оба верно", "Оба не верны" },
                                                      "Оба верно",
                                                      testList));
            testList.TestQuestions.Add(CreateQuestion("Что возвращает Операции сравнения?",
                                                      new string[] { "true", "false", "Да", "Нет", "Верны true, false", "Верны да, нет" },
                                                      "Верны true, false",
                                                      testList));
            testList.TestQuestions.Add(CreateQuestion("Условные выражения – сложные логические конструкции, в языке программирования C#, которые",
                                                      new string[] { "Используются для просмотра статистики программы.",
                                                                     "Используются для управлением ходом выполнения выделения памяти.",
                                                                     "Используются для управления ходом выполнения программы." },
                                                      "Используются для управления ходом выполнения программы.",
                                                      testList));

            return testList;
        }

        private TestList TestList_2(Subtitle subtitle)
        {
            TestList testList = CreateTestList("Операции сравнения: Тест", subtitle);

            testList.TestQuestions.Add(CreateQuestion("Какая операция сравнивает два операнда на равенство, если они равны то возвращает true?",
                                                      new string[] { "==", "!=", "=" },
                                                      "==",
                                                      testList));
            testList.TestQuestions.Add(CreateQuestion("Какая операция сравнивает два операнда на равенство, если они не равны то возвращает true?",
                                                      new string[] { "=", "!=", ">=" },
                                                      "!=",
                                                      testList));
            testList.TestQuestions.Add(CreateQuestion("Какая операция сравнивает два операнда и возвращает true, если первый операнд больше второго, иначе возвращает false?",
                                                      new string[] { ">", ">=", "!>" },
                                                      ">",
                                                      testList));
            testList.TestQuestions.Add(CreateQuestion("Какая операция сравнивает два операнда и возвращает true, если первый операнд меньше или равен второму. Иначе возвращает false?",
                                                      new string[] { ">=", ">", "Нет правильного ответа" },
                                                      "Нет правильного ответа",
                                                      testList));
            testList.TestQuestions.Add(CreateQuestion("Какая операция сравнивает два операнда и возвращает true, если первый операнд больше или равен второму, иначе возвращается false?",
                                                      new string[] { ">", ">=", "==" },
                                                      ">=",
                                                      testList));

            return testList;
        }

        private TestList TestList_3(Subtitle subtitle)
        {
            TestList testList = CreateTestList("Логические операции: Тест", subtitle);

            testList.TestQuestions.Add(CreateQuestion("Операция логического сложения или логическое ИЛИ. Возвращает true, если хотя бы один из операндов возвращает true.",
                                                      new string[] { "|", "||", "|||" },
                                                      "|",
                                                      testList));
            testList.TestQuestions.Add(CreateQuestion("Операция логического умножения или логическое И. Возвращает true, если оба операнда одновременно равны true.",
                                                      new string[] { "!", "Нет правильного ответа", "Не >=" },
                                                      "Нет правильного ответа",
                                                      testList));
            testList.TestQuestions.Add(CreateQuestion("Операция логического умножения или логическое И. Возвращает true, если оба операнда одновременно равны true.",
                                                      new string[] { "||", ">=", "!>" },
                                                      "||",
                                                      testList));
            testList.TestQuestions.Add(CreateQuestion("Операция логического отрицания. Производится над одним операндом и возвращает true, если операнд равен false. Если операнд равен true, то операция возвращает false:",
                                                      new string[] { ">=", ">", "!" },
                                                      "!",
                                                      testList));
            testList.TestQuestions.Add(CreateQuestion("Операция исключающего ИЛИ. Возвращает true, если либо первый, либо второй операнд (но не одновременно) равны true, иначе возвращает false",
                                                      new string[] { ">", "^", "==" },
                                                      "^",
                                                      testList));

            return testList;
        }
        #endregion
    }
}
