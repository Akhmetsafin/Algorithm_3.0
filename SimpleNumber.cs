using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_3._0
{
   public  class SimpleNumber
    {


        /// <summary>
        /// метод проверки чисел
        /// </summary>
        public void Verification_SimpleNumber()
        {
            int i = 2;
            int d = 0;
            string value;
            string text = Console.ReadLine();
            if (int.TryParse(text, out int numberInter))

            {
                while (i < numberInter)
                {
                    if (numberInter % i == 0)
                    {
                        i++;
                        d++;
                        continue;
                    }
                    else
                    {
                        i++;
                        continue;
                    }
                }
                {
                    if (d == 0)
                    {
                        value = "это число - простое";
                    }
                    else
                    {
                        value = "это число - не простое";
                    }
                }
                Console.WriteLine(value);
                Console.WriteLine("продолжить нажмите любую клавишу, выйти нажмите ESC");
            }
            else
            {
                Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
            }
        }
        /// <summary>
        ///  Компановка и выход проверки простых чисел
        /// </summary>
        public void Core_SimpleNumber()
        {
            Console.WriteLine("Программа определения простых и не простых чисел");
            Console.WriteLine("Введите число: ");
            Verification_SimpleNumber();


        }
    }
}
