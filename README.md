# İnsan Kaynakları Personel Yönetim Sistemi

 Bu proje, bir işletmedeki çalışanların bilgilerinin, izin durumlarının, maaş bilgilerinin ve performanslarının takip edilmesini amaçlar. Amaç, insan kaynakları süreçlerini dijitalleştirip raporlanabilir hale getirmektir.

 ## Proje Özellikleri

- Giriş Ekranı (LoginForm): Kullanıcı adı ve parola ile giriş yapılır. Rolüne göre menüdeki erişimler belirlenir.
- Personel Yönetimi (EmployeeForm): Yeni personel ekleme, düzenleme, silme. Departman, görev, maaş bilgileri.
- Departman Yönetimi (DepartmentForm): Departman ekleme/silme. Departman bazlı personel görüntüleme.
- İzin Yönetimi (LeaveForm): Personel izin talebi oluşturur. Yönetici onaylar veya reddeder.
- Maaş Hesaplama (SalaryForm): Maaş, prim, kesinti bilgileri. Net maaş hesaplama.
- Performans Değerlendirme (PerformanceForm): Performans puanları ve dönemsel analiz.
- Raporlama Ekranı (ReportForm): Tarih, departman veya personel bazlı filtreleme ile çeşitli raporlar alınır.

 ## Kullanılan Teknolojiler

- C# (.NET Framework)
- Windows Forms (Masaüstü uygulama tasarımı)
- MySQL (Veritabanı)
- Entity Layer: Katmanlı mimari (DAL, BLL)
- Responsive Tasarım: Modern ve kullanıcı dostu arayüz.

## Ekran Görüntüleri

### Giriş Sayfası
![Giriş Sayfası](https://github.com/gulseren03/Personel-Takip-Sistemi-Projesi/blob/main/giri%C5%9F%20sayfas%C4%B1.png)
Giriş Sayfası, insan kaynakları personel takip sistemi kullanıcılarının uygulamaya erişim sağlamasını ve yetkilerine göre doğru sayfaya yönlendirilmesini sağlar. Kullanıcı adı, şifre ve rol bilgilerine göre, sistem ilgili kullanıcının bir Personel mi, İK mı yoksa Yönetici mi olduğunu kontrol eder ve bu doğrultuda uygun sayfayı açar.

### Ana Menü
![Ana Menü](https://github.com/gulseren03/Personel-Takip-Sistemi-Projesi/blob/main/Ana%20men%C3%BC.png)
Ana Menü, insan kaynakları personel takip sistemi kullanıcılarının tüm sistem özelliklerine erişebileceği merkezi bir kontrol panelidir. Kullanıcılar yetkileri doğrultusunda çeşitli işlemleri bu ekran üzerinden gerçekleştirebilir. Personel İK ve Yönetici rolleri için uygun erişim izinleri sağlanmıştır.

### İzin İşlemleri
![İzin İşlemleri](
