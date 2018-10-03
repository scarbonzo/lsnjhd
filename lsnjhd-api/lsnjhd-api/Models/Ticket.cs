using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Ticket
{
    public Guid Id { get; set; }

    public Program Program { get; set; }
    public Office Office { get; set; }
    public User EndUser { get; set; }

    public TicketType TicketType { get; set; }
    public string Title { get; set; }
    public string Summary { get; set; }

    public Status Status { get; set; }
    public Severity Severity { get; set; }
    
    public List<Note> Notes { get; set; }
    public List<Event> AuditTrail { get; set; }
    
    public DateTime Created { get; set; }
    public User CreatedBy { get; set; }

    public DateTime Updated { get; set; }
    public User UpdatedBy { get; set; }

    public DateTime Closed { get; set; }
    public User ClosedBy { get; set; }
}
