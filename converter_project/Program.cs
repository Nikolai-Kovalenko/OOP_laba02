using System;

namespace converter_project
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Convert convert = new Convert
            {
                
            };

            Console.WriteLine("Выбери валюту для конвертации");
            byte i = 1;
            while (i < 2)
            {
                string val = Console.ReadLine();

                switch (val)
                {
                    case "rub":
                        Console.WriteLine("Валюта для конветрации принята");
                        i = 2;
                        break;
                    case "usd":
                        Console.WriteLine("Валюта для конветрации принята");
                        i = 2;
                        break;
                    case "eur":
                        Console.WriteLine("Валюта для конветрации принята");
                        i = 2;
                        break;
                    default: 
                        Console.WriteLine("Нужно выбрать из предлагаемых валют: rub, eur, usd");
                        i = 1;
                        break;
                }
            }
                        
            Console.WriteLine("Выбери конвертируемую валюту");
            byte j = 1;
            while (j < 2)
            {
                string val1 = Console.ReadLine();

                switch (val1)
                {
                    case "rub":
                        Console.WriteLine("Валюта для конветрации принята");
                        j = 2;
                        break;
                    case "usd":
                        Console.WriteLine("Валюта для конветрации принята");
                        j = 2;
                        break;
                    case "eur":
                        Console.WriteLine("Валюта для конветрации принята");
                        j = 2;
                        break;
                    default: 
                        Console.WriteLine("Нужно выбрать из предлагаемых валют: rub, eur, usd");
                        j = 1;
                        break;
                }
            }

            Console.WriteLine("Какое количество ?");
            double count;
            count = Convert.ToDouble(Console.ReadLine());

            convert.Convert(i, j, count);
        }
    }
}