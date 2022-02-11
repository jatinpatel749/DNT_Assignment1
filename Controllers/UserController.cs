using Microsoft.AspNetCore.Mvc;
using DNT_Assignment.Models;


namespace DNT_Assignment.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            SignUpViewModel _SignUpViewModel = new SignUpViewModel();

            return View(_SignUpViewModel);
        }



        [HttpPost]
        public IActionResult SignUp(SignUpViewModel ModelData)
        {

            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }

            SignUpViewModel _SignUpViewModel = new SignUpViewModel();
            
            return View(_SignUpViewModel);
        }



        [HttpGet]
        public IActionResult ChangeCityByCountry(int cid)
        {
            SignUpViewModel _SignUpViewModel = new SignUpViewModel();

            return Json(_SignUpViewModel.GetCityByCountryID(cid));
        }
    }
}
