using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Notes.Models;

namespace Notes.Controllers
{
    [Route("createTask")]
    [ApiController]
    public class CreateTaskController : ControllerBase
    {
        [HttpGet]
        public IActionResult createtask(string login, string task, DateTime start, DateTime end)
        {
            using (var db = new DataBaseContext())
            {
                try
                {
                    var AddInTable = new Tasks
                    {
                        Login = login,
                        Task = task,
                        Start = start,
                        End = end
                    };

                    db.Tasks.Add(AddInTable);
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
