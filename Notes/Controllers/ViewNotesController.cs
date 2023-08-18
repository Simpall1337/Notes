using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Notes.Controllers
{
    [Route("viewnotes")]
    [ApiController]
    public class ViewNotesController : ControllerBase
    {

        [HttpGet]
        public IActionResult View(string login)
        {
            using (var db = new DataBaseContext())
            {
                var View = db.Tasks.Where(x => x.Login == login).ToList();
                
               return Ok(View);


            }

        }

    }
}
