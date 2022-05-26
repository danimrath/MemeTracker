using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemeTracker.DataService
{
    public class Meme
    {
        public Guid Id { get; set; }
        public Guid PersonMemeId { get; set; } 
        public decimal ShareRating { get; set; }
    }
}
