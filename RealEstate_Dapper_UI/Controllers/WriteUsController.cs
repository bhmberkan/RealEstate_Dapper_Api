using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.Dtos.ContactDtos;
using System.Net.Http;
using System.Text;
using MailKit.Net.Smtp;

namespace RealEstate_Dapper_UI.Controllers
{
    public class WriteUsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public WriteUsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>  Index(CreateContactDto createContactDto)
        {

            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddress = new MailboxAddress(createContactDto.Name, createContactDto.Email);
            mimeMessage.From.Add(mailboxAddress); // mesaj kimden 

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", "berkanburakturgut@gmail.com" /* kime */);
            mimeMessage.To.Add(mailboxAddressTo); // mesaj kime 

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = createContactDto.Message + " \n \nSender : " + createContactDto.Email; // mesajın içerik ne 
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = createContactDto.Subject;

            SmtpClient client2 = new SmtpClient();
            client2.Connect("smtp.gmail.com", 587, false); // 587 port numarası , ssl gereksin mi = fasle istersen true yaparsın
            client2.Authenticate("berkanburakturgut@gmail.com", "fwsdhhdhrzzhgqmq");
            client2.Send(mimeMessage);
            client2.Disconnect(true);


            createContactDto.SendDate = DateTime.Now;
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createContactDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:44358/api/Contacts", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
