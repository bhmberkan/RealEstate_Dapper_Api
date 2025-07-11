using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_UI.Services;
using System.Security.Claims;

namespace RealEstate_Dapper_UI.ViewComponents.EstateAgent
{
    
    public class _EstateAgentLayoutSidebarComponentPartial :ViewComponent
    {
      

        public IViewComponentResult Invoke()
        {
            //var userClaims = HttpContext.User.Claims;
            //var userName = userClaims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value;

            
            //ViewBag.UserName = userName;
            return View();  
        }
    }
}
