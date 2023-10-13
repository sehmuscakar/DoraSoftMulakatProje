using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPollUserManager _pollUserManager;
        private readonly IPollReportManager _pollReportManager;
        private readonly IPostContactManager _postContactManager;
        public HomeController(IPollUserManager pollUserManager, IPollReportManager pollReportManager, IPostContactManager postContactManager)
        {
            _pollUserManager = pollUserManager;
            _pollReportManager = pollReportManager;
            _postContactManager = postContactManager;
        }

        public async Task<IActionResult> Anasayfa()
        {
            return View();
        }

        public async Task<IActionResult> About() // bunlar menu layota bağlı olacak 
        {
            return View();
        }
        public async Task<IActionResult> Service()
        {
            return View();
        }
        public async Task<IActionResult> Team()
        {
            return View();
        }

        public async Task<IActionResult> Testimonial()
        {
            return View();
        }

        public async Task<IActionResult> Poll()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> PollForm()
        {
           
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PollForm(PollUser pollUser)
        {
            //gönderilecek olan kişin bilgileri
            MimeMessage mimeMessage = new MimeMessage();// minekit kütüphanesi eklemen lazım bunun için maile doğrulama yapmak için 

            MailboxAddress mailboxAddressFrom = new MailboxAddress("DoraSoft Araştırma ve Danışmanlık", "scakar542@gmail.com");//kimden geleceği isim ve mail

            mimeMessage.From.Add(mailboxAddressFrom);//kimden gelecek ekle
                                                     //alacak olan kişin bilgileri
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", pollUser.PostMail);//kime gideği isim ve adres

            mimeMessage.To.Add(mailboxAddressTo);//kime gidecek ekle

            //  mimeMessage.Subject = contact.Subject;// bu direk mail başlığında yazar
            mimeMessage.Subject = "Ankete katıldığınız için TEŞEKKÜR EDERİZ :)";// bu direk mail başlığında yazar

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = "Katıldığınız Anket Numarası: " + pollUser.PollId + "***" + "Ankete Katılma Tarihiniz: " + DateTime.Now + "***" + "Web Sitemiz üzerinden katıldığınız anketin *RAPOR* verilerine dorasoftanket.com adresi üzerinden ulaşabilirsiniz Teşekkürler :):):)";
            mimeMessage.Body = bodyBuilder.ToMessageBody();   //mesaja ekle body kısmına 

            //mimeMessage.Subject = "Easy Cash Onay Kodu";//konu kısmı

            SmtpClient client = new SmtpClient();// mail trnsfer nesne örneği protokol
            client.Connect("smtp.gmail.com", 587, false);//prokol gereklikleri bağlantı kurma ,burda bağlatı güvenliğine false dedik çünkü ConfirmMailController da true işlemi yapacaz emailconfirmed

            client.Authenticate("scakar542@gmail.com", "nceghxlgsgjbnfvb");//mail ve mailde oluşturduğun güvenlik kodu,bunu her bir ayrı projede ayrı al bu güvenlik kodunu mail üzerinden bazı işlmlerle alırsın
            client.Send(mimeMessage);//gönder
            client.Disconnect(true);//gövenli çıkış yap 
                                    //bu işlemi yapman için iki adımlı doğrulamyı mail de açman lazım
           
            _pollUserManager.Add(pollUser);
            return View();
        }

        public async Task<IActionResult> PollReport(int id)
        {
            var datagetir=_pollReportManager.GetByID(id);
            return View(datagetir);
        }

        public async Task<IActionResult> Contact()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Contact(PostContact postContact)
        {

            //gönderilecek olan kişin bilgileri
            MimeMessage mimeMessage = new MimeMessage();// minekit kütüphanesi eklemen lazım bunun için maile doğrulama yapmak için 

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Web'ten Mesajınız", "scakar542@gmail.com");//kimden geleceği isim ve mail

            mimeMessage.From.Add(mailboxAddressFrom);//kimden gelecek ekle
                                                     //alacak olan kişin bilgileri
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", postContact.Mail);//kime gideği isim ve adres

            mimeMessage.To.Add(mailboxAddressTo);//kime gidecek ekle

            //  mimeMessage.Subject = contact.Subject;// bu direk mail başlığında yazar
            mimeMessage.Subject = "DoraSoft Araştırma ve Danışmanlık";// bu direk mail başlığında yazar

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = "Gönderen Adı: " + postContact.Name + "***" + "Konu: " + postContact.Subject + "***" + "Gönderilen Mesaj: " + postContact.Message;
            mimeMessage.Body = bodyBuilder.ToMessageBody();   //mesaja ekle body kısmına 

            //mimeMessage.Subject = "Easy Cash Onay Kodu";//konu kısmı

            SmtpClient client = new SmtpClient();// mail trnsfer nesne örneği protokol
            client.Connect("smtp.gmail.com", 587, false);//prokol gereklikleri bağlantı kurma ,burda bağlatı güvenliğine false dedik çünkü ConfirmMailController da true işlemi yapacaz emailconfirmed

            client.Authenticate("scakar542@gmail.com", "nceghxlgsgjbnfvb");//mail ve mailde oluşturduğun güvenlik kodu,bunu her bir ayrı projede ayrı al bu güvenlik kodunu mail üzerinden bazı işlmlerle alırsın
            client.Send(mimeMessage);//gönder
            client.Disconnect(true);//gövenli çıkış yap 
                                    //bu işlemi yapman için iki adımlı doğrulamyı mail de açman lazım
            _postContactManager.Add(postContact);
            return View();
        }

      

    }
}