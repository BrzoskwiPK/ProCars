using System;

namespace WPFApplication.Models
{
    public class Car
    {
        public Guid Id { get; }
        public string Make { get; }
        public string Model { get; }
        public int Year { get; }
        public string Color { get; }
        public int Mileage { get; }
        public string Engine { get; }
        public decimal Price { get; }

        public Car(Guid id, string make, string model, int year, string color, int mileage, string engine, decimal price)
        {
            Id = id;
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            Mileage = mileage;
            Engine = engine;
            Price = price;
        }
    }
}
