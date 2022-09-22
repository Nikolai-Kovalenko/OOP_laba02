using System;

namespace address_project
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Address address = new Address
            {
                Index = 41000,
                Country = "Ukraine",
                City = "Shostka",
                Street = "Robocha",
                House = 6,
                Appartment = 14
            };
            Console.WriteLine(address.ToString());
        }
    }
}