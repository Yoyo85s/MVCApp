using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class AccountDetailsAddressInfoModel
    {
        [Display(Name = "Addrss line 1" , Prompt = "Enter your addrss ", Order = 0)]
        [Required (ErrorMessage ="Address is required")]
        public string Addressline_1 { get; set; } = null!;

        [Display(Name = "Addrss line 2", Prompt = "Enter your  second address" , Order = 1)]
        
        public string? Addressline_2 { get; set; }

        [Display(Name = "PostalCode", Prompt = "Enter your postalCode", Order = 2)]
        [Required(ErrorMessage = "PostalCode is required")]
        [DataType(DataType.PostalCode)]

        public string PostalCode { get; set; } = null!;

        [Display(Name = "City", Prompt = "Enter your city", Order = 3)]
        [Required(ErrorMessage = "City is required")]
        
        public string City { get; set; } = null!;
    }
}
