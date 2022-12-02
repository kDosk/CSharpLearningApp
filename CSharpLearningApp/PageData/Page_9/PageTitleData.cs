﻿using CSharpLearningApp.Classes;
using CSharpLearningApp.Models.PageModels.TestModels;
using CSharpLearningApp.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearningApp.PageData.Page_9
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
                string theory_1 = " Метод - это именованный блок кода, который выполняет некоторые действия." +
                                " В C# определение метода состоит из любых модификаторов (таких как спецификация доступности), " +
                                " типа возвращаемого значения, " +
                                " за которым следует имя метода," +
                                " затем список аргументов в круглых скобках и далее - тело метода.  " +
                                " Классы представляют связанные между собой объекты. " +
                                " К ним могут относится const, int и другие. " +
                                " Служат для хранения электронных материалов. Но такие «составляющие кода» способны содержать функции." +
                                " Функции, которые определяются в пределах класса – это и есть методы C#. Они могут быть прописаны как внутри, так и за пределами class " +
                                " Метод – блок кода, который содержит в себе ряд инструкций и указаний. " +
                                " Программа рассматривает его в качестве инструкций – метод вызывается, после чего указываются все его аргументы. " +
                                " Программа инициирует выполнение инструкций, вызывая метод и указывая все аргументы, необходимые для этого метода. " +
                                " В C# все инструкции выполняются в контексте метода. " +
                                " Обязательными элементами для определения метода в C# являются: " +
                                " тип возвращаемого значения и имя метода. " +
                                " Самый первый пример метода, который мы могли видеть в C# — это метод Main(), который является и точкой входа для консольного приложения." +
                                " static — это модификатор. О том, что он обозначает, мы поговорим позднее, когда доберемся до работы с классами и объектами в C#." +
                                " void — тип возвращаемого значения. Это ключевое слово используется для того, чтобы указать, что метод не возвращает ничего. " +
                                " Main — это имя метода. " +
                                " string[] args— это единственный параметр метода — массив строк." +
                                " Каждый параметр состоит из имени типа параметра и имени, по которому к нему можно обратиться в теле метода. " +
                                " Вдобавок, если метод возвращает значение, то для указания точки выхода должен использоваться оператор возврата return вместе с возвращаемым значением. " +
                                " Если метод не возвращает ничего, то в качестве типа возврата указывается void, поскольку вообще опустить тип возврата невозможно. " +
                                " Если же он не принимает аргументов, то все равно после имени метода должны присутствовать пустые круглые скобки. " +
                                " При этом включать в тело метода оператор возврата не обязательно — метод возвращает управление автоматически по достижении закрывающей фигурной скобки.";

                string theory_2 = "Все три метода вызываются в основном методе программы – Main. " +
                                " Они имеют модификатор доступа static. " +
                                " Первые два метода типа void, то есть ничего не возвращают." +
                                " PrintHelloWorld – вызывает Console.WriteLine с текстовым аргументом." +
                                " PrintHello – принимает в качестве аргумента текстовую строку и после модификации текста, передает его в другой метод Console.WriteLine, который выводит текст в консоль." +
                                " Cube – принимает на вход целое число, возводит его в куб и возвращает результат." +
                                "Вызов метода – это переход в начало его тела и превращение параметров в локальные переменные с инициализацией их значениями соответствующих аргументов. " +
                                " Метод выполняет до своего конца или до инструкции return. " +
                                " После выполнения мы возвращаемся в точку его вызова. " +
                                " Если мы укажем в качестве возвращаемого значения void, то можем не использовать return, " +
                                " а если будем использовать то должны это делать без значения так, как указали что он ничего не возвращает." +
                                " Метод может называть себя. Это называется рекурсией." +
                                " При вызове метода мы переходим в его тело и начинаем выполнять вложенные в него инструкции. " +
                                " Для вызова нам нужно применить к его имени оператор вызова, который представляется круглыми скобками." +
                                " Внутри этого оператора через запятую мы перечисляем аргументы метода, те данные которые он от нас требует." +
                                " Помимо этого, метод может возвращать данные, которые в языковых конструкциях воспринимаются как результат выполнения оператора вызова. " +
                                " Так что вызов метода можно встретить в самых неожиданных местах." +
                                " Чаще всего в классе присутствует один или несколько методов. Каждый из них выполняет определенное действие. " +
                                " Методами они называются потому, что именно в них описывается метод выполнения действий – пошаговые инструкции, задающие порядок выполнения операций." +
                                " Строка, начинающаяся с двух символов \"слеш\" (//), называется комментарием. Комментарии только поясняют код, но не влияют на выполнение программы." +
                                " Операция \"+\" определена над строками. " +
                                " Она называется сцеплением строк, или конкатенацией. " +
                                " Результатом операции является приписывание второй строки в конец первой." +
                                " Как уже говорилось, объекты класса Person могут объявляться и создаваться в методах другого класса." +
                                " Когда встречается вызов метода ShowFullName, " +
                                " компьютер находит в классе Person метод с таким именем и – шаг за шагом – выполняет описанные в нем действия.";

                string theory_3 = "Сокращенная запись методов." +
                                " 1) Атрибуты и спецификторы являются необязательными элементами в описании метода. " +
                                " На данном этапе атрибуты нами использоваться не будут, а из всех спецификаторов мы в обязательном порядке будем использовать спецификатор static, который позволяет обращатся к методу класса без создания его экземпляра. " +
                                " Остальные спецификаторы мы рассмотрим позже." +
                                " 2) тип_результата определяет тип значения, возвращаемого методом. " +
                                " Это может быть любой тип, включая типы классов, создаваемые программистом, а также тип void, который говорит о том, что метод ничего не возвращает." +
                                " 3) имя_метода будет использоваться для обращания к нему из других мест программы и должно быть корректно заданным, " +
                                " с учетом требований, накладываемых на идентификаторы в С#." +
                                " 4) список_формальных_параметров представляет собой последовательность пар, состоящих из типа данных и идентификатора, разделенных запятыми." +
                                " Формальные параметры – это переменные, которые получают значения, передаваемые методу при вызове. " +
                                " Если метод не имеет параметров, то список_параметров остается пустым." +
                                " 5) return – это оператор безусловного перехода, который завершает работу метода и возвращает значение, стоящие после оператора return, в точку его вызова." +
                                " Тип значения должен соответствовать типу_результата, или приводиться к нему. " +
                                " Если метод не должен возвращать никакого значения, то указывается тип void, и в этом случае оператор return либо отсутствует, либо указывается без возвращаемого значения." +
                                " Метод может возвращать значение, какой-либо результат. В примере выше были определены два метода, которые имели тип void. " +
                                " Методы с таким типом не возвращают никакого значения. Они просто выполняют некоторые действия." +
                                " Если метод имеет любой другой тип, отличный от void, то такой метод обязан вернуть значение этого типа. Для этого применяется оператор return." +
                                " Метод GetHello имеет тип string, следовательно, он должен возвратить строку." +
                                " Поэтому в теле метода используется оператор return, после которого указана возвращаемая строка." +
                                " Метод GetSum имеет тип int, следовательно, он должен возвратить значение типа int - целое число. " +
                                " Поэтому в теле метода используется оператор return, после которого указано возвращаемое число (в данном случае результат суммы переменных x и y)." +
                                " То есть после списка параметров ставится оператор =>, после которого идет выполняемая инструкция.";
                #endregion

                #region Add subtitles to title
                title.Subtitles.AddRange(new List<Subtitle>
                {
                    Subtitle_1("Глава 1: Определение метода",
                               theory_1,
                               title),
                    Subtitle_2("Глава 2. Вызов методов",
                               theory_2,
                               title),
                    Subtitle_3("Глава 3. Сокращенная запись методов",
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

            subtitle.TestList = null;

            return subtitle;
        }

        private Subtitle Subtitle_2(string name, string theoryContent, Title title)
        {
            Subtitle subtitle = AddSubtitle(name, theoryContent, title);

            subtitle.TestList = null;

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
    }
}
