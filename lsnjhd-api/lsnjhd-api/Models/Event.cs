using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Event
{
    public Guid Id { get; set; }

    public string Message { get; set; }

    public DateTime Created { get; set; }
}
