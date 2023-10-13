using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class About: BaseEntity
    {
        public string Description { get; set; }
        public string SubDescription1 { get; set; }
        public string SubDescription2 { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string TitleDescription1 { get; set; }
        public string TitleDescription2 { get; set; }

        public string ImageUrl { get; set; }
    }
}
