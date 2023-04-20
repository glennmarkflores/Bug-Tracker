using System.ComponentModel;

namespace Bug_Tracker.Models
{
    public class TicketStatus
    {
        public int Id { get; set; }

        [DisplayName("Status Name")]
        public string Name { get; set; }

    }
}
