using System;

namespace address_project
{
  public class Address
    {
        private int index;
        private string country;
        private string city;
        private string street;
        private int house;
        private int appartment;

        public int Index
        {
            set
            {
                if (value > 0)
                {
                    index = value;
                }
                else
                {
                    Console.WriteLine("Значение должно быть больше нуля");
                }
            }
            get
            {
                return index;
            }
        }
        
        public string Country
        {
            set
            {
                country = value;
            }
            get
            {
                return country;
            }
        }
        
        public string City
        {
            set
            {
                city = value;
            }
            get
            {
                return city;
            }
        }

        public string Street
        {
            set
            {
                street = value;
            }
            get
            {
                return street;
            }
        }
        
        public int House
        {
            set
            {
                if (value > 0)
                {
                    house = value;
                }
                else
                {
                    Console.WriteLine("Значение должно быть больше нуля");
                }
            }
            get
            {
                return house;
            }
        }
        
        public int Appartment
        {
            set
            {
                if (value > 0)
                {
                    appartment = value;
                }
                else
                {
                    Console.WriteLine("Значение должно быть больше нуля");
                }
            }
            get
            {
                return appartment;
            }
        }
        
        public override string ToString()
        {
            return $"{index}, {country}: {city}; {street} {house}, {appartment}";
        }
    }
}











