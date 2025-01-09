using Best_Practices.Models;
using System;

namespace Best_Practices.ModelBuilders
{
    public class CarBuilder
    {
        private Car _car;

        public CarBuilder()
        {
            // Inicializa propiedades por defecto
            _car = new Car
            {
                Brand = "Ford",
                Color = "DefaultColor",
                Year = DateTime.Now.Year,
                Model = "DefaultModel"
            };
        }

        public CarBuilder SetBrand(string brand)
        {
            _car.Brand = brand;
            return this;
        }

        public CarBuilder SetModel(string model)
        {
            _car.Model = model;
            return this;
        }

        public CarBuilder SetColor(string color)
        {
            _car.Color = color;
            return this;
        }

        public CarBuilder SetYear(int year)
        {
            _car.Year = year;
            return this;
        }

        // ...Podrías continuar con más propiedades

        public Car Build()
        {
            return _car;
        }
    }
}
