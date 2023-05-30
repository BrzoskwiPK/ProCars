﻿namespace WPFApplication.EntityFramework.DTOs
{
    public class CarDTO
    {
        public Guid Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }
        public string Engine { get; set; }
        public decimal Price { get; set; }
    }
}
