using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Poll:BaseEntity
    {
        public string ImageUrl { get; set; }

        public string Subject { get; set; }
        public string Description { get; set; }

        public bool IsActive { get; set; }

        public DateTime LastTime { get; set; } //son zaman

        public int PollCategoryId { get; set; }
        public PollCategory PollCategory { get; set; }
        public int PollReportId { get; set; }
        public PollReport PollReport { get; set; }

        public List<PollUser> PollUsers { get; set; }

    }
}
