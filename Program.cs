using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {

        
        
        

        static void Main(string[] args)

        {
            List<decimal> levels;

            levels = new List<decimal>();


            

            Console.WriteLine("Задайте нижнию цену:   ");

            string str = Console.ReadLine();

            int loprice = Convert.ToInt32(str);



            Console.WriteLine("Задайте верхнию цену:   ");

            string str1 = Console.ReadLine();

            decimal priceup = decimal.Parse(str);



            Console.WriteLine("Введите шаг уровня:   ");

            str = Console.ReadLine();

            decimal steplevel = decimal.Parse(str);

            decimal pricelevel = priceup;

            for (int i = 0; i < levels.Count; i++)
            {
                if (priceup <= loprice)
                    break;





                
            }
            WriteLine();

            Console.WriteLine(levels);

            void WriteLine()
            {

                Console.WriteLine("Количество элементов в списке:  " + levels.Count.ToString());

                for (int i = 0; i < levels.Count; i++)

                {
                    Console.WriteLine(levels[i]);

                }

                Console.ReadLine();

            }
        }
    }
}
