using DNT_Assignment.Attributes;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;


namespace DNT_Assignment.Models
{
    public class SignUpViewModel
    {
        #region Get Methods
        public List<SelectListItem> GetCountryList()
        {
            List<SelectListItem> CountryList = new List<SelectListItem>();
            CountryList.Add(new SelectListItem { Text = "India", Value = "1" });
            CountryList.Add(new SelectListItem { Text = "USA", Value = "2" });
            CountryList.Add(new SelectListItem { Text = "Canada", Value = "3" });
            CountryList.Add(new SelectListItem { Text = "Australia", Value = "4" });
            return CountryList;
        }
        public List<SelectListItem> GetGenderList()
        {
            List<SelectListItem> GenderList = new List<SelectListItem>();
            GenderList.Add(new SelectListItem { Text = "Male", Value = "1" });
            GenderList.Add(new SelectListItem { Text = "Female", Value = "2" });
            return GenderList;
        }
        public List<SelectListItem> GetCityByCountryID(int cid)
        {
            List<SelectListItem> CityList = new List<SelectListItem>();
            if (cid == 1)
            {
                CityList.Add(new SelectListItem { Text = "Vadodara", Value = "1" });
                CityList.Add(new SelectListItem { Text = "Surat", Value = "2" });
                CityList.Add(new SelectListItem { Text = "Mumbai", Value = "3" });
                CityList.Add(new SelectListItem { Text = "Pune", Value = "4" });
            }
            else if (cid == 2)
            {
                CityList.Add(new SelectListItem { Text = "NJ", Value = "5" });
                CityList.Add(new SelectListItem { Text = "NY", Value = "6" });
            }
            else if (cid == 3)
            {
                CityList.Add(new SelectListItem { Text = "Toronto", Value = "7" });
                CityList.Add(new SelectListItem { Text = "Ottawa", Value = "8" });
            }
            else if (cid == 4)
            {
                CityList.Add(new SelectListItem { Text = "Melbourne", Value = "9" });
                CityList.Add(new SelectListItem { Text = "Sydney ", Value = "10" });
            }
            else
            {
                CityList.Add(new SelectListItem { Text = "Others ", Value = "100" });
            }
            return CityList;
        }
        #endregion

        public SignUpViewModel() // we can assign data using constructor
        {
            Countries = GetCountryList();
            GenderList = GetGenderList();
        }
        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter Confirm Password")]
        [Compare("Password", ErrorMessage = "Confirm Password doesn't match")]
        public string ConfirmPassword { get; set; }


        [Required(ErrorMessage = "Please Enter Contact")]
        [RegularExpression("^[6789]\\d{9}", ErrorMessage = "Please Enter Correct Contact No")]
        public string Contact { get; set; }

        public List<SelectListItem>? Countries { get; set; }
        [Required(ErrorMessage = "Please Select Country.")]
        [Display(Name = "Country")]
        public int CountryId { get; set; }

        public List<SelectListItem>? Cities { get; set; }
        [Required(ErrorMessage = "Please Select City.")]
        [Display(Name = "City")]
        public int CityId { get; set; }


        public List<SelectListItem>? GenderList { get; set; }
        [Required(ErrorMessage = "Gender Required")] // group of radio button will show
        [Display(Name = "Gender ")]
        public string Gender { get; set; }

        [ValidateCheckBox(ErrorMessage = "Please Accept Terms")]
        public bool AcceptTerms { get; set; }
    }
}
