using System;
using System.Collections.Generic;
using System.Text;

namespace MemeTracker.DataService
{
    public class Behavior
    {
        public Guid Id { get; set; }
        public Activity Activity { get; set; }
        public decimal Probability { get; set; }
    }
}
