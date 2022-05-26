using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemeTracker.DataService
{
    public class ActivityHistory
    {
        public Guid Id { get; set; }
        public Guid MemeId { get; set; }
        public Guid SourcePersonId { get; set; }
        public Guid DestSourceId { get; set; }
        public int Round { get; set; }
    }
}
