
public class StylistController : Controller
{
  // ... other action methods ...

  private IEnumerable<SelectListItem> GetSpecialtySelectList()
  {
    return new List<SelectListItem>
        {
            new SelectListItem { Value = "ShortHair", Text = "Short Hair" },
            new SelectListItem { Value = "LongHair", Text = "Long Hair" },
            new SelectListItem { Value = "CurlyHair", Text = "Curly Hair" },
            new SelectListItem { Value = "Colorist", Text = "Colorist" }
        };
  }
}







