using System;
using System.Collections.Generic;
using System.Text;

namespace MemeTracker.DataService
{
    public class Person
    {
        public Guid Id { get; set; }
        public List<Friend> Friends { get; set; }
        public List<Behavior> Behaviors { get; set; }
    }
}