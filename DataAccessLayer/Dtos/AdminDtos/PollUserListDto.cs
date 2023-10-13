using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dtos.AdminDtos
{
    public class PollUserListDto
    {
        public int Id { get; set; }
        public string PostMail { get; set; }
        public bool GenderMan { get; set; }
        public bool GenderWomen { get; set; }
        public bool GenderUncertain { get; set; }

        public int Age { get; set; }

        public string City { get; set; }

        public bool Positive { get; set; }
        public bool Negative { get; set; }
        public bool Uncertain { get; set; }
        public bool UniversityDiplaed { get; set; }
        public bool UniversityNot { get; set; }
        public int PollId { get; set; }
        public string PollSubject { get; set; }
        public string PollDescription { get; set; }
    

        public DateTime? CreatedAt { get; set; }
        public int RowOrder { get; set; }

    }
}
