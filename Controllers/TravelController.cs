using Microsoft.AspNetCore.Mvc;
using NewApplication1.Data;
using NewApplication1.Models;
using NewApplication1.Models.Entities;

namespace NewApplication1.Controllers
{
    public class TravelController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public TravelController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddTravelViewModel viewModel)
        {
            var travel = new Travels
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                MobileNumber = viewModel.MobileNumber,
                Nationality = viewModel.Nationality,
                Gender = viewModel.Gender,
                DateofArrival = viewModel.DateofArrival,
                DateofDepature = viewModel.DateofDepature,
                Destination = viewModel.Destination,
                Count = viewModel.Count,
                Password = viewModel.Password,
                
            };
            await dbContext.Travels.AddAsync(travel);
            await dbContext.SaveChangesAsync();
            
            
            TempData["Error"] = "Registered Successfully";
            return RedirectToAction("Add", "Travel");
            //return View();

        }

        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel credentials)
        {
            bool UserExist = dbContext.Travels.Any(x => x.Email== credentials.UserName && x.Password == credentials.Password);
            //dbContext.patient.FirstOrDefault(x => x.UserName == credentials.UserName && x.password == credentials.password);

            if (UserExist)
            {

                return RedirectToAction("Index", "Home");


            }
            ModelState.AddModelError("", "Invalid login Attempt");
            return View();
        }


    }
}
