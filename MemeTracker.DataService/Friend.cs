using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemeTracker.DataService
{
    public class Friend
    {
        public Guid Id { get; set; }
        public Guid PersonId { get; set; }
        public Guid FriendId { get; set; }
        public decimal Weight { get; set; }
    }
}
