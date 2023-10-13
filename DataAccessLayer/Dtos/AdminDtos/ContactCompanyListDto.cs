namespace DataAccessLayer.Dtos.AdminDtos
{
    public class ContactCompanyListDto:AdminBaseDto
    {
        public string Address { get; set; }
        public string MailCity { get; set; }
        public string Phone { get; set; }
        public string Twiter { get; set; }
        public string Facebook { get; set; }
        public string Instegram { get; set; }
        public string Linkedin { get; set; }
        public string Skype { get; set; }
    }
}
