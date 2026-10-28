using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            // 1. Toplam Mesaj Sayısı
            ViewBag.v1 = context.Messages.Count();

            // 2. Okunmamış Mesaj Sayısı
            ViewBag.v2 = context.Messages.Where(x => x.IsRead == false).Count();

            // 3. Okunmuş Mesaj Sayısı
            ViewBag.v3 = context.Messages.Where(x => x.IsRead == true).Count();

            // 4. Teşekkür Konulu Mesaj Sayısı
            ViewBag.v4 = context.Messages.Where(x => x.Subject.Contains("Teşekkür")).Count();

            // 5. Proje Talebi Konulu Mesaj Sayısı
            ViewBag.v5 = context.Messages.Where(x => x.Subject.Contains("Proje")).Count();

            // 6. Gmail Adresinden Gelen Mesaj Sayısı
            ViewBag.v6 = context.Messages.Where(x => x.Email.Contains("@gmail.com")).Count();

            // 7. Son Gelen Mesajın Gönderen Adı
            ViewBag.v7 = context.Messages.OrderByDescending(x => x.MessageId).Select(x => x.NameSurname).FirstOrDefault();

            // 8. Son Gelen Mesajın Konusu
            ViewBag.v8 = context.Messages.OrderByDescending(x => x.MessageId).Select(x => x.Subject).FirstOrDefault();

            // 9. Son Gelen Mesajın Tarihi
            ViewBag.v9 = context.Messages.OrderByDescending(x => x.MessageId).Select(x => x.SendDate).FirstOrDefault();

            // 10. İlk Gelen Mesajın Gönderen Adı
            ViewBag.v10 = context.Messages.OrderBy(x => x.MessageId).Select(x => x.NameSurname).FirstOrDefault();

            // 11. Bugün Gelen Mesaj Sayısı
            ViewBag.v11 = context.Messages.Where(x => x.SendDate.Date == DateTime.Today).Count();

            // 12. Bu Ay Gelen Mesaj Sayısı
            ViewBag.v12 = context.Messages.Where(x => x.SendDate.Month == DateTime.Now.Month && x.SendDate.Year == DateTime.Now.Year).Count();

            // 13. Mesaj Detayı 20 Karakterden Uzun Olan Mesaj Sayısı
            ViewBag.v13 = context.Messages.Where(x => x.MessageDetail.Length > 20).Count();

            // 14. Konusu 'Özür' veya 'Şikayet' Olan Mesaj Sayısı
            ViewBag.v14 = context.Messages.Where(x => x.Subject.Contains("Özür") || x.Subject.Contains("Şikayet")).Count();

            // 15. En Çok Mesaj Gönderen Kişinin Adı
            ViewBag.v15 = context.Messages.GroupBy(x => x.NameSurname)
                                          .OrderByDescending(g => g.Count())
                                          .Select(g => g.Key)
                                          .FirstOrDefault();

            // 16. Konusu 'Özür' veya 'Şikayet' Olan Mesaj Sayısı
            ViewBag.v16 = context.Messages.Where(x => x.IsRead == false)
                                          .OrderByDescending(x => x.MessageId)
                                          .Select(x => x.NameSurname)
                                          .FirstOrDefault();

            return View();
        }
    }
}
