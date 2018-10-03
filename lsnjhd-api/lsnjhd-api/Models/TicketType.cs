using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class TicketType
{
    public Guid Id { get; set; }

    public string Name { get; set; }
    public bool Active { get; set; }
    public TicketTemplate Template { get; set; }

    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
}
