using WebApp.Models;

namespace WebApp.ViewModels;

public class AccountDetailsViewModel
{
    public string Title { get; set; } = "Account Details";
    public AccountDetailsBasicInfoModel BasicInfo { get; set; } = new AccountDetailsBasicInfoModel()
    {
        ProfileImage = "/images/profile-picture.svg",
        FirstName = "Yassser",
        LastName = "Sahli",
        Email = "yasser@domain.com"
        // to do 
       

    };

    public AccountDetailsAddressInfoModel AddressInfo { get; set; } = new AccountDetailsAddressInfoModel();
}
