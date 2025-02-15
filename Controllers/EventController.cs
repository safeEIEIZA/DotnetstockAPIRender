using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class EventController : ControllerBase
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; } 
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
    }

    private static readonly List<Event> Events = new List<Event>
    {
            new Event { Id = 1, Title = "Meeting Team A", Start = new DateTime(2025, 2, 17, 9, 0, 0), End = new DateTime(2025, 2, 19, 17, 0, 0) },
            new Event { Id = 2, Title = "Sale Team Report", Start = new DateTime(2025, 2, 22, 10, 30, 0), End = new DateTime(2025, 2, 23, 14, 0, 0) },
            new Event { Id = 3, Title = "ประชุมทีม DevOpt", Start = new DateTime(2025, 2, 24, 9, 0, 0) }, 
            new Event { Id = 4, Title = "ส่งงาน", Start = new DateTime(2025, 2, 27, 9, 30, 0) }, 
            new Event { Id = 5, Title = "จัดเลี้ยง", Start = new DateTime(2025, 3, 2, 19, 0, 0) },
            new Event { Id = 6, Title = "วันหยุด", Start = new DateTime(2025, 3, 2, 19, 0, 0) }


    };

    [HttpGet]
    public ActionResult<IEnumerable<Event>> GetEvents()
    {
        return Ok(Events);
    }
}
