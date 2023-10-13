using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dtos.AdminDtos
{
   public class PollReportListDto:AdminBaseDto
    {
        public int ManCount { get; set; }
        public int WomenCount { get; set; }
        public int WomenAvg { get; set; }
        public int ManAvg { get; set; }
        public int PositiveCount { get; set; }
        public int NegativeCount { get; set; }
        public int Noİdea { get; set; }
        public int UniversityDiplomad { get; set; }
        public int UniversityNot { get; set; }
    }
}
