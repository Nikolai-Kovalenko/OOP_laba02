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
