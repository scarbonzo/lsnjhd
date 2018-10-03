using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Office
{
    public Guid Id { get; set; }

    public Program Program { get; set; }
    public string Name { get; set; }
    public bool Active { get; set; }

    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
}
