namespace WebApp.Models.Components;

public class LinkViewModel
{
    public string ControllerName { get; set; } = null!;
    public string ActionName { get; set; } = null!;
    public string Text { get; set; } = null!;

    public string? BrandsText { get; set; } // here I put it because of error BUT in video Hans put it in ShowcaseViewModel too 

}
