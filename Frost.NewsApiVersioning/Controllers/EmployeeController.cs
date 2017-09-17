using Frost.NewsApiVersioning.Models;
using Microsoft.AspNetCore.Mvc;

namespace Frost.NewsApiVersioning.Controllers
{
   [Produces("application/json")]
   [Route("api/Employee")]
   public class EmployeeController : Controller
   {
      // GET: api/Employee
      [Route("~/api/GetName")]
      [HttpGet]
      public string GetName()
      {
         return new Employee() { Name = "Mike Koch" }.Name;
      }
   }
}