using System;

namespace converter_project
{
    public class Converter
    {
        public static void Result(double inputD, double outputD, double countD)
        {
            double result = countD * inputD / outputD;
            Console.WriteLine("Результат: " + result);
        }

        public static void Convert(string inputV, string outputV, double countV)
        {
            switch (inputV)
            {
                case"usd":
                    double value1 = 39.5f;
                    break;
                case"eur":
                    double value1 = 42.3f;
                    break;
                case"rub":
                    double value1 = 0.62f;
                    break;
            }
            
            switch (outputV)
            {
                case"usd":
                    double value2 = 39.5f;
                    break;
                case"eur":
                    double value2 = 42.3f;
                    break;
                case"rub":
                    double value2 = 0.62f;
                    break;
            }

            if (countV < 0)
            {
                Console.WriteLine("Значение должно быть больше нуля");
            }
            else
            {
                double value3 = countV;
            }
            
            Result(value1, value2, value3);
        }
    }
}