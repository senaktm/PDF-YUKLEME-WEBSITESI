# PDF-YUKLEME-WEBSITESI

                                                                                                                                 
 ÖZET :
Projede admin ve kullanıcının ayrı giriş yapabileceği bir web uygulaması yapılması istenmiştir. Kullanıcı sisteme pdf yükleyebilmelidir. Admin kullanıcı ekleyebilmeli, kullanıcı bilgilerini güncelleyebilmeli ve silebilmelidir. Admin yüklenen pdfler üzerinden sorgu gerçekleştirerek pdfler arasında filtreleme yapabilmelidir.
1.GİRİŞ: 
Proje Visual Studio kullanılarak C# dilinde yazılmıştır. Web Form kullanılarak proje tasarlanmıştır. PDF işlemlerini yapabilmek adına Nuget Paketi yüklemesi yapılmıştır.

2. YÖNTEM :
  ARAYÜZ VE TASARIM
Proje Web form kullanılarak oluşturulmuştur.

Yukarıdaki seçeneklerden admin ve ya kullanici girişi seçilerek seçilen LOGIN sayfasına gider




 
Kullanıcı pdf yükleme sayfasında pdf yükler.
 
Kaydedilen pdfin bilgilerini basar.
 

Admin Panelinde admin yüklenen pdfleri sorgulama yapar.
 
Admin Panelinde admin kişi ekleme,güncelleme ve silme işlemlerini yapar.

 

VERİ TABANI
Programımızda veri tabanı olarak Mysql kullanılmıştır. Projede ana tablolar ve ilişkili tablolar kullanndık. Bu ilişkilerde çoka çok, teke çok, teke tek ilişkilerden faydalandık ve bir tabloda yapılan değişikliğin diğer tabloları dinamik olarak etkilemesi sağlandı.
Kurduğumuz ilişkiler sayesinde yakaladığımız dinamik yapı veritabanında oluşabilecek yanlış kayıtları veya hataları engelleyerek, iş yükünü azaltacaktır.Tüm bu işlemlerden sonra elimizde normalizasyon kurallarına olabildiğince uygun, tabloları oluşturulmuş kullanıma hazır bir şema oluşturmuş olmaktayız.

3. DENEYSEL SONUÇLAR
HTML ile web formunun tasarımı yapılmıştır.
Mysql ile ilişkili tablolar oluşturulmuştur.
Yüklenen pdf dosyasından bilgiler elde edilirken dinamik bir yapı kurduk. Bu yapı kurulurken birçok dosya okuma hataları ile karşılaştık. Bunları araştırarak ve farklı yollar deneyerek istediğimiz sonucu elde ettik. Veritabanında mysql sorgularımızı gerçekleştirirken pek çok yeni hatalar ile karşılaştık. Bu hataları araştırarak gerekli çözüm yollarını bulduk.

4. SONUÇ
Projemiz sayesinde Web uygulama yapmayı, tasarlamayı, web uygulaması ile veritabanı arasında dinamik bağlantı kurmayı, web uygulamanın temel gereksinimlerini öğrenmiş olduk. Bu sayede pek çok yeni bilgi öğrenildi. 
5. KAYNAKÇA
https://docs.microsoft.com/en-us/troubleshoot/aspnet/upload-file-to-web-site

https://docs.microsoft.com/tr-tr/visualstudio/get-started/csharp/tutorial-aspnet-core?view=vs-2022

https://www.w3schools.com/asp/default.ASP
https://www.youtube.com/watch?v=me1FB6OpCeI
https://www.yazilimkodlama.com/web/asp-net-ile-dosya-yukleme-file-upload/








































































