using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemeTracker.DataService
{
    public class PersonMeme
    {
        public Guid Id { get; set; }
        public Guid PersonId { get; set; }
        public Guid MemeId  { get; set; }
    }
}
