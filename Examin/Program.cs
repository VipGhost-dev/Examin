using System;
using System.Diagnostics;

namespace Examin
{
    class Program
    {
        static void Main(string[] args)
        {
            double vkl= 700000; //вклад
            int percent = 1; //процентная ставка

            ///<summary>
            ///Создание файла диагностики при запуске программы
            /// </summary>
            DebugTrace.onStart();
            DebugTrace.DebugWrite("Программа успешно запущена");
        }

        /// <summary>
        /// Постановка процента по вкладу
        /// </summary>
        /// <param name="percent">Процентная ставка</param>
        /// <param name="vkl">Вклад</param>
        /// <returns></returns>
        public static int setPercent(int percent,double vkl)
        {
            if (vkl < 50000 && vkl > 0)
            {
                percent = 1;
            }
            else if (vkl < 100000 && vkl > 49999.99)
            {
                percent = 2;
            }
            else if (vkl < 150000 && vkl > 99999.99)
            {
                percent = 3;
            }
            else if (vkl < 200000 && vkl > 149999.99)
            {
                percent = 4;
                
            }
            else if (vkl < 250000 && vkl > 199999.99)
            {
                percent = 5;
                
            }
            else if (vkl < 300000 && vkl > 249999.99)
            {
                percent = 6;
                
            }
            else if (vkl < 350000 && vkl > 299999.99)
            {
                percent = 7;
                
            }
            else if (vkl < 400000 && vkl > 349999.99)
            {
                percent = 8;
                
            }
            else if (vkl < 450000 && vkl > 399999.99)
            {
                percent = 9;
                
            }
            else if (vkl < 500000 && vkl > 449999.99)
            {
                percent = 10;
                
            }
            else if (vkl < 550000 && vkl > 499999.99)
            {
                percent = 11;
                
            }
            else if (vkl < 600000 && vkl > 549999.99)
            {
                percent = 12;
                
            }
            else if (vkl < 650000 && vkl > 599999.99)
            {
                percent = 13;
                
            }
            else if (vkl < 700000 && vkl > 649999.99)
            {
                percent = 14;
                
            }
            else if (vkl < 750000 && vkl > 699999.99)
            {
                percent = 20;
                
            }
            else if (vkl < 800000 && vkl > 749999.99)
            {
                percent = 19;
                
            }
            else if (vkl < 850000 && vkl > 799999.99)
            {
                percent = 18;
                
            }
            else if (vkl < 900000 && vkl > 849999.99)
            {
                percent = 17;
                
            }
            else if (vkl < 950000 && vkl > 899999.99)
            {
                percent = 16;
                
            }
            else if (vkl < 1000000 && vkl > 949999.99)
            {
                percent = 15;
                
            }
            return percent;
        }
    }
}
