using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using WebApp.Helpers;

namespace WebApp.Models;

public class SignUpModel
{
    [Display(Name = "First Name", Prompt = "Enter your first name", Order = 0)]
    [Required(ErrorMessage = "First name is required")]
    public string FirstName { get; set; } = null!;

    [Display(Name = "Last Name", Prompt = "Enter your last name", Order = 1)]
    [Required(ErrorMessage = "Last name is required")]
    public string LastName { get; set; } = null!;

    
    [Display(Name = "Email address", Prompt = "Enter your Email address", Order = 2)]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "Email is required")]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Your email address is invalid")]
    public string Email { get; set; } = null!;
    
    [Display(Name = "Password", Prompt = "Enter your password", Order = 3)]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Password is required")]
    [RegularExpression(@"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage = "Invalid password")]
    
    public string Password { get; set; } = null!;

    [Display(Name = "ConfirmPassword", Prompt = "Re write your password", Order = 4)]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Password must be confirmed")]
    [Compare(nameof (Password), ErrorMessage = "Password don't match")]
    public string ConfirmPassword { get; set; } = null!;

    [Display(Name = "I agree to the Terms & Conditions.", Order = 5)]
    //[Required(ErrorMessage = "You must accept the terms and conditions.")]
    [CheckboxRequired(ErrorMessage = "You must accept the terms and conditions to proceed.")]
    public bool TermsAndConditions { get; set; } = false;

    

}




