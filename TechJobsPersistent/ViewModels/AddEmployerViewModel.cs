using System.ComponentModel.DataAnnotations;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {

        [Required(ErrorMessage = "Employer Name is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 20 characters long")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Employer Location is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 20 characters long")]
        public string Location { get; set; }


        public AddEmployerViewModel()
        { }


        public AddEmployerViewModel(string name, string location)
        { 
            Name = name;
            Location = location;    
        }
    }
}
