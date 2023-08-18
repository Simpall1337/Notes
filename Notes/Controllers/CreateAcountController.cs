using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Notes.Models
{
    [Route("createaccount")]
    [ApiController]

    public class CreateAcountController : ControllerBase
    {
        [HttpGet]
        public IActionResult CreateAcc(string login,string password)
        {
            using (var db = new DataBaseContext())
            {
                try
                {
                    if (login == null || password == null)
                        return BadRequest();

                    var AddInTable = new User
                    {
                        Login = login,
                        Password = password
                    };

                    db.Users.Add(AddInTable);
                    db.SaveChanges();
                    return Ok();
                }
                catch (Exception)
                {

                    return BadRequest();
                }
                
            }
        }

        
    }
}
