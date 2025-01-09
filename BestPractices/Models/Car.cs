using System;

namespace Best_Practices.Models
{
    // Ejemplo de clase Car que implementa la interfaz IVehicle
    public class Car : IVehicle
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        // Opcional: constructor
        public Car()
        {
            // Por defecto, año actual
            Year = DateTime.Now.Year;
        }

        public override string ToString()
        {
            return $"{Brand} {Model} ({Year}) - Color: {Color}";
        }
    }
}
