using Best_Practices.Models;

namespace Best_Practices.Infraestructure.Factories
{
    public class FordMustangCreator : Creator
    {
        public override Vehicle CreateVehicle()
        {
            // Retorna una instancia de Car con datos de un Mustang
            return new Car
            {
                Brand = "Ford",
                Model = "Mustang",
                Color = "Red",
                Year = System.DateTime.Now.Year
            };
        }
    }
}
