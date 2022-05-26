using System;
using System.Collections.Generic;
using System.Text;

namespace MemeTracker.DataService
{
    public class Behavior
    {
        public Guid Id { get; set; }
        public BehaviorType BehaviorType { get; set; }
        public Guid PersonId { get; set; }
        public Guid ActivityId { get; set; }
        public decimal Probability { get; set; }
    }

    public enum BehaviorType
    {
        Create,
        Share,
        Read,
        DoNothing
    }
}
