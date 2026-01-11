# İnsan Kaynakları Personel Yönetim Sistemi

 Bu proje, bir işletmedeki çalışanların bilgilerinin, izin durumlarının, maaş bilgilerinin ve performanslarının takip edilmesini amaçlar. Amaç, insan kaynakları süreçlerini dijitalleştirip raporlanabilir hale getirmektir.

 ## :pushpin: Proje Özellikleri

- **Giriş Ekranı** : Kullanıcı adı ve parola ile giriş yapılır. Rolüne göre menüdeki erişimler belirlenir.
- **Personel Yönetimi** : Yeni personel ekleme, düzenleme, silme. Departman, görev, maaş bilgileri.
- **Departman Yönetimi** : Departman ekleme/silme. Departman bazlı personel görüntüleme.
- **İzin Yönetimi** : Personel izin talebi oluşturur. Yönetici onaylar veya reddeder.
- **Maaş Hesaplama** : Maaş, prim, kesinti bilgileri. Net maaş hesaplama.
- **Performans Değerlendirme** : Performans puanları ve dönemsel analiz.
- **Raporlama Ekranı** : Tarih, departman veya personel bazlı filtreleme ile çeşitli raporlar alınır.

 ## :computer: Kullanılan Teknolojiler

- **C#** (.NET Framework)
- **Windows Forms** (Masaüstü uygulama tasarımı)
- **MySQL** (Veritabanı)
- **Entity Layer**: Katmanlı mimari (DAL, BLL)
- **Responsive Tasarım**: Modern ve kullanıcı dostu arayüz.

## 📸 Ekran Görüntüleri

### Giriş Sayfası
![Giriş Sayfası](https://github.com/gulseren03/Personel-Takip-Sistemi-Projesi/blob/main/Giri%C5%9F%20ekran%C4%B1.png)
Giriş Sayfası, insan kaynakları personel takip sistemi kullanıcılarının uygulamaya erişim sağlamasını ve yetkilerine göre doğru sayfaya yönlendirilmesini sağlar. Kullanıcı adı, şifre ve rol bilgilerine göre, sistem ilgili kullanıcının bir Personel mi, İK mı yoksa Yönetici mi olduğunu kontrol eder ve bu doğrultuda uygun sayfayı açar.

### Ana Menü
![Ana Menü](https://github.com/gulseren03/Personel-Takip-Sistemi-Projesi/blob/main/Ana%20men%C3%BC.png)
Ana Menü, insan kaynakları personel takip sistemi kullanıcılarının tüm sistem özelliklerine erişebileceği merkezi bir kontrol panelidir. Kullanıcılar yetkileri doğrultusunda çeşitli işlemleri bu ekran üzerinden gerçekleştirebilir. Personel İK ve Yönetici rolleri için uygun erişim izinleri sağlanmıştır.

### İzin İşlemleri Ekranı
![İzin İşlemleri](https://github.com/gulseren03/Personel-Takip-Sistemi-Projesi/blob/main/ik%20izin%20olustur.png))
![İzin İşlemleri](https://github.com/gulseren03/Personel-Takip-Sistemi-Projesi/blob/main/personel%20%C4%B1z%C4%B1n%20olusturma.png)
![İzin İşlemleri](https://github.com/gulseren03/Personel-Takip-Sistemi-Projesi/blob/main/yonet%C4%B1c%C4%B1%20%C4%B1z%C4%B1n.png)
İzin İşlemleri, insan kaynakları personel takip sistemi kullanıcılarının izin işlemlerini görüntülemesini sağlayan paneldir.Kullanıcılar yetkileri doğrultusunda çeşitli işlemleri bu ekran üzerinden gerçekleştirebilir. Personel İK ve Yönetici rolleri için erişim izinleri sağlanmıştır.

### Personel Yönetimi Ekranı
![Personel Yönetimi](https://github.com/gulseren03/Personel-Takip-Sistemi-Projesi/blob/main/ik%20personel%20yonet%C4%B1m%C4%B1.png)
Personel Yönetimi,insan kaynakları personel takip sistemi kullanıcılarının rollerine göre personelleri görüntüleyebilme,ekleme ve silme işlemleri sağlayan paneldir. Personel İK ve Yönetici rolleri için erişim izinleri sağlanmıştır.

### Performans Ekranı
![Performans](https://github.com/gulseren03/Personel-Takip-Sistemi-Projesi/blob/main/ik%20performans%20ekle.png)
Personel Yönetimi,insan kaynakları personel takip sistemi kullanıcılarının rollerine göre performans puanları girebilme ve tüm personellerin performans puanlarının görüntülendiği ekrandır. Personel İK ve Yönetici rolleri için erişim izinleri sağlanmıştır.

### Maaş Hesaplama Ekranı
![ Maaş Hesaplama](https://github.com/gulseren03/Personel-Takip-Sistemi-Projesi/blob/main/maas%20hesaplama%20yeni.png)
Personel Yönetimi,insan kaynakları personel takip sistemi kullanıcılarının rollerine göre Maaş, prim, kesinti bilgileri ve Net maaş hesaplamalarının görüntülenebilmesini sağlar. Personel İK ve Yönetici rolleri için erişim izinleri sağlanmıştır.

### Raporlama Ekranı
![Raporlama](https://github.com/gulseren03/Personel-Takip-Sistemi-Projesi/blob/main/rporlar.png)
Personel Yönetimi,insan kaynakları personel takip sistemi kullanıcılarının rollerine göre  Tarih, departman veya personel bazlı filtreleme ile çeşitli raporlar alınmasını sağlayan paneldir.Personel İK ve Yönetici rolleri için erişim izinleri sağlanmıştır.




## 📂 Kullanım

1. Projeyi [indirin](https://github.com/gulseren03/Personel-Takip-Sistemi-Projesi/tree/main)
2. **Visual Studio** kullanarak projeyi açın.
3. Gerekli **MySQL** bağlantı ayarlarını ***Db.cs*** dosyasından yapılandırın.
4. Uygulamayı çalıştırın ve giriş ekranından kullanıcı bilgilerinizi girerek başlayın.        


## 🛠️ Proje Yapısı

- **DAL (Data Access Layer)**: Veritabanı işlemleri.
- **BLL (Business Logic Layer)**: İş mantığı.
- **UI (User Interface)**: Windows Forms kullanıcı arayüzü.
- **MySQL**: Veritabanı bağlantı ve sorguları.


## 📞 İletişim

- **Ad** : Gülseren
- **Soyad** : Memiş
- **Tel No** : +90 538 230 1921
- **E Posta** : [gulseren20051979@gmail.com](gulseren20051979@gmail.com)

  
 ## ▶️ Youtube Video

 Youtube proje videosunu izlemek için [Tıklayın](https://youtu.be/slmLDC-Dqhg)
  
