using System;

namespace TemperatureConverter
{

    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Write the Farenheit temperature:");
            string temperature = Console.ReadLine();

            var converter = new Converter();
            double result = converter.FarenheitToCelsius(Convert.ToDouble(temperature));

            Console.WriteLine(String.Format("The temperature in Celsius is {0}", result));
            Console.ReadLine();
        }

    }

}