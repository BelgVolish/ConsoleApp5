using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

namespace HomeWorkTask2
{
    class Program
    {

        static void Main(string[] args)
        {
            int CardsCount = 0;
            int CardsSumm = 0;
            Console.WriteLine("Здравствуйсте, введите количество карт");
            CardsCount = Convert.ToInt32(Console.ReadLine());
            for (int i = CardsCount; i > 0; i--)
            {
                Console.WriteLine("Пожалуйста, введите Номинал карты");

                switch (Console.ReadLine()) 
                {
                    case "Q":
                        CardsSumm += 10;
                        break;
                    case "K":
                        CardsSumm += 10;
                        break;
                    case "J":
                        CardsSumm += 10;
                        break;
                    case "T":
                        CardsSumm += 10;
                        break;
                    default:
                        CardsSumm += Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            
            Console.WriteLine("Сумма номиналов ваших кард:" + CardsSumm);
        }    

            
        
    }






}
