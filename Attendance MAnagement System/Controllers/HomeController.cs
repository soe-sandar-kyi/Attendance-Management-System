using Attendance_MAnagement_System.Interfaces;
using Attendance_MAnagement_System.Models;
using Attendance_MAnagement_System.Models.Dao;
using Attendance_MAnagement_System.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Attendance_MAnagement_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly UserManager<Employee> _userManager;
        private readonly SignInManager<Employee> _signInManager;

        public HomeController(ILogger<HomeController> logger,IEmployeeRepository employeeRepository, UserManager<Employee> userManager, SignInManager<Employee> signInManager)
        {
            _logger = logger;
            _employeeRepository = employeeRepository;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            var response = new LoginViewModel();
            return View(response);
        }

        public IActionResult Register()
        {
            var response = new RegisterViewModel();
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {

            if (!ModelState.IsValid) return View(registerViewModel);

            /// var user = await _userManager.FindByEmailAsync(registerViewModel.EmailAddress);
            //var user=await _userManager.FindByIdAsync(registerViewModel.Id);
            //if (user != null)
            //{
            //    TempData["Error"] = "This email address is already in used";
            //    return View(registerViewModel);
            //}

            var employee = new Employee
            {
                Id = registerViewModel.Id,
                Name = registerViewModel.Name,
                EmailAddress = registerViewModel.EmailAddress,
                PhoneNumber = registerViewModel.Password,
                DOB = DateTime.Now,
                ManagerId = registerViewModel.ManagerID,
                ManagerName = registerViewModel.ManagerName,
                role=registerViewModel.roleCategory,
            };

           // var newUserResponse = await _userManager.CreateAsync(employee);

            //if (newUserResponse.Succeeded)
            //    await _userManager.AddToRoleAsync(employee, registerViewModel.roleCategory.ToString());
            _employeeRepository.Add(employee);
            return RedirectToAction("Index", "Home");
           
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
