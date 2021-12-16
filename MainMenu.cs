using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using static Algorithm_3._0.PointDoubleClass;

namespace Algorithm_3._0
{
    public class MainMenu
    {
        public string menuText = "Добро пожаловать в меню Домашних заданий по предмету Алгоритмы \n" +
                "Выберите ниже из списка:\n" +
                "1 Урок №1- Проверка числа простое/непростое\n" +
                "2 Урок №1- Число Фибоначи рекурсивный метотод / обычный метод\n" +
                "3 Урок №2- Двусвязный список\n" +
              /*  "4 Урок №3- Tecт Benchmark\n" +*/
                "9-Выход";
        /// <summary>
        /// Главное Меню для программы
        /// </summary>
        /// <returns></returns>
        public void ProjectMenu()
        {
            string text = Console.ReadLine();
            do
            {
                if (int.TryParse(text, out int numberInter))
                {
                    if (numberInter == 1)
                        SimpleNumbers();

                    if (numberInter == 2)
                        FibonachiNum();

                    if (numberInter == 3)
                        DualLinkedList();

                    if (numberInter == 4)
                    {
                        ClassStructureBenchmark();
                        BenchmarkRunner.Run<MainMenu>();
                    }

                    if (numberInter == 9)
                        Environment.Exit(0);
                    Console.WriteLine("Для выхода в главное меню нажмите ESC");
                }
                else
                {
                    Console.WriteLine("Команда не распознана");
                }
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            Console.Clear();
            Console.WriteLine(menuText);
            ProjectMenu();
        }
        //------------------------------------------------

        /// <summary>
        /// Точка вывода проекта с проверкой простых чисел
        /// </summary>
        public void SimpleNumbers()
        {
            SimpleNumber simple_Number = new SimpleNumber();
            simple_Number.Core_SimpleNumber();
        }
        //------------------------------------------------
        /// <summary>
        /// Точка вывода проекта чисел Фибоначи
        /// </summary>
        public void FibonachiNum()
        {
            FibonachiNum fibonachiNum = new FibonachiNum();
            fibonachiNum.Core_FibonachiNum();
        }
        //-------------------------------------------------
        /// <summary>
        /// Точка вывода проекта Двусвязного списка
        /// </summary>
        public void DualLinkedList()
        {
            Node node = new Node();
            node.Run_DualLinkedList();
        }
        //-------------------------------------------------
        [Benchmark]
        public void ClassStructureBenchmark()
        {
            PointDoubleClass pointDoubleClass = new PointDoubleClass(2, 2);
            pointDoubleClass.ClassDouble();
            PointDoublestruct pointDoublestruct = new PointDoublestruct(2, 2);
            pointDoublestruct.StructDouble();



        }
    }
}
