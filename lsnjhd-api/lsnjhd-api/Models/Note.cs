using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Note
{
    public Guid Id { get; set; }
    
    public string Title { get; set; }
    public string Contents { get; set; }

    public DateTime Created { get; set; }
    public User CreatedBy { get; set; }
    public DateTime Updated { get; set; }
    public User UpdatedBy { get; set; }
}
