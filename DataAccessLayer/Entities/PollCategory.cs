using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class PollCategory:BaseEntity
    {
        public string Name { get; set; }

        public List<Poll> Polls { get; set; }   
    }
}
