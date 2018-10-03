using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Task
{
    public Guid Id { get; set; }

    public string Name { get; set; }
   
    
    public bool Complete { get; set; }

    public List<Event> AuditTrail { get; set; }

    public DateTime Created { get; set; }
    public User CreatedBy { get; set; }
    public DateTime Updated { get; set; }
    public User UpdatedBy { get; set; }
    public DateTime Completed { get; set; }
    public User CompletedBy { get; set; }
}
