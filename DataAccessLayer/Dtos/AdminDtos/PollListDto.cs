namespace DataAccessLayer.Dtos.AdminDtos
{
    public class PollListDto:AdminBaseDto
    {
        public string ImageUrl { get; set; }

        public string Subject { get; set; }
        public string Description { get; set; }

        public bool IsActive { get; set; }
        public DateTime LastTime { get; set; }
        public string PollCategoryName { get; set; }
     
        public int PollReportId { get; set; }
    
    }
}
