using System.ComponentModel.DataAnnotations;

namespace PalomaTestApp.Models
{
    //Basic event model
    public class Event
    {
        //Unique ID added for every event.
        [Key]
        public int ID { get; set; }
		//Event name.
		[StringLength(60, MinimumLength = 3)]
		[Required]
        public string Name { get; set; }
		//Event description.
		[StringLength(60, MinimumLength = 5)]
		public string Description { get; set; } 
        //Event location.
        public string? Location { get; set; }
        //Event created date.
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
		//Date of the event.
		[Display(Name = "Event Date")]
		[Required]
        public DateTime EventDate { get; set; }
    }
}
