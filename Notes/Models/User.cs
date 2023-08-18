using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Notes.Models
{
    public class User
    {

        public string Login { get; set; }
        public string Password { get; set; }

    }
}
