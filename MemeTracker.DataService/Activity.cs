using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemeTracker.DataService
{
    public class Activity
    {
        public Guid Id { get; set; }
        public BehaviorType ActivityType { get; set; }
    }
}
