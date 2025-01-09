using Best_Practices.Models;

namespace Best_Practices.Infraestructure.Factories
{
    public class FordExplorerCreator : Creator
    {
        public override Vehicle CreateVehicle()
        {
            return new Car
            {
                Brand = "Ford",
                Model = "Explorer",
                Color = "Black",
                Year = System.DateTime.Now.Year
            };
        }
    }
}
