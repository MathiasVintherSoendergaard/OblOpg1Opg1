using System;

namespace OblOpg1Opg1
{
    public class Car
    {
        private int id;
        public int Id 
        {
            get => id;
            set 
            {
                id = value;
            }
        }
        private string model;
        public string Model 
        { 
            get => model;
            set 
            {
                if (value.Length >= 4)
                {
                    model = value;
                }
                else throw new ArgumentOutOfRangeException("Model", value, "is too short");
            } 
        }
        private int price;
        public int Price 
        { 
            get => price;
            set 
            {
                if (value > 0)
                {
                    price = value;
                }
                else throw new ArgumentOutOfRangeException("Price", value, "is too low");
            }
        }
        private string licensePlate;
        public string LicensePlate
        {
            get => licensePlate;
            set 
            {
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("License Place", value, "is too short");
                }
                else if (value.Length > 7)
                {
                    throw new ArgumentOutOfRangeException("License Plate", value, "is too long");
                }
                else licensePlate = value;
            } 
        }
        public Car() { }
        public Car(int _id, string _model, int _price, string _licensePlate)
        {
            Id = _id;
            Model = _model;
            Price = _price;
            LicensePlate = _licensePlate;
        }
    }
}
