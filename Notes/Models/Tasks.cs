using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Notes.Models
{
    public class Tasks
    {
        
        public int Id { get; set; }
        public string Login { get; set; }
        public string Task { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; } 

        [ForeignKey("Login")]
        public User User { get; set; }

    }
}
