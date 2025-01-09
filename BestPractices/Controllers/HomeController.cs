using Best_Practices.Infraestructure.Factories;
using Best_Practices.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Best_Practices.Controllers
{
    public class HomeController : Controller
    {
        // Repositorio (InMemory)
        private readonly IVehicleRepository _vehicleRepo;

        // Fábricas (puedes inyectar una, o varias)
        private readonly Creator _fordMustangCreator;
        private readonly Creator _fordExplorerCreator;

        public HomeController(
            IVehicleRepository vehicleRepo,
            FordMustangCreator mustangCreator,
            FordExplorerCreator explorerCreator
        )
        {
            _vehicleRepo = vehicleRepo;
            _fordMustangCreator = mustangCreator;
            _fordExplorerCreator = explorerCreator;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddMustang()
        {
            var mustang = _fordMustangCreator.CreateVehicle();
            _vehicleRepo.Add(mustang);
            return RedirectToAction("ShowCars");
        }

        public IActionResult AddExplorer()
        {
            var explorer = _fordExplorerCreator.CreateVehicle();
            _vehicleRepo.Add(explorer);
            return RedirectToAction("ShowCars");
        }

        public IActionResult ShowCars()
        {
            var allVehicles = _vehicleRepo.GetAll();
            return View(allVehicles); 
            // Cree una vista "ShowCars.cshtml" que recorra y muestre la lista
        }
    }
}
