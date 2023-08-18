using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Notes.Controllers
{
    [Route("login")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        [HttpPost]
        public IActionResult login(string login,string password)
        {
            using (var db = new DataBaseContext())
            {

                var data = db.Users.ToList();

                foreach (var item in data)
                {
                    if (item.Login == login && item.Password == password)
                    {
                        Console.WriteLine("yes");
                        return Ok();
                    }

                }

            }

            return BadRequest();
        }
    }
}
