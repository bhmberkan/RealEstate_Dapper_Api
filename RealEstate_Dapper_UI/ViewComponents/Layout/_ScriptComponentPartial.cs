using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.ViewComponents.Layout
{
    public class _ScriptComponentPartial : ViewComponent
    {
      public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
