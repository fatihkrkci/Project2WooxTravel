#  WoOx Travel
Bu proje M&Y Yazılım Eğitim Akademi Danışmanlık bünyesinde Murat Yücedağ eğitmenliği tarafından verilen ödev kapsamında ASP.NET MVC kullanılarak yapılan 2. projedir.

# Projeye Genel Bakış
👤 <b>Kullanıcı Arayüzü:</b> Sayfa açıldığında kullanıcıyı <b>-son eklenen 4 destinasyonun veritabanından dinamik olarak geldiği-</b> bir slider/banner karşılıyor. Otomatik olarak değişen bannerlar arasında isterse kullanıcı da manuel olarak geçişler yapabiliyor. Banner üzerinde yer alan 'İncele' butonu aracılığıyla <b>destinasyonun detay sayfasına gidebilme imkanı</b> da bulunmaktadır. Slider/banner'ın hemen altında yer alan alanda ise tüm destinasyonların bir listesi yer almaktadır. Burada her sayfada 5 destinasyon olacak şekilde bir <b>Sayfalama Yapısı</b> kullanılmıştır. Son olarak ise kullanıcı isterse navbar üzerinde bulunan 'Rezervasyon Yap' butonuna tıklayıp karşısına çıkan <b>'Rezervasyon Oluşturma Pop-Up'ı</b> aracılığıyla rezervasyon oluşturabilir. Bu pop-up'ı detaylıca incelememiz gerekirse kullanıcının bilgilerini girdiği ve kullanıcıya kolaylık sağlamak adına <b>telefon numarası alanının giriş değerlerinin maskelenerek 0(000) 000 00 00 formatına getirildiği</b> bir pop-up'tır.
<br/><br/>
🖱️ <b>Admin Paneli:</b> Site yöneticileri için geliştirilmiş olan bu panel üzerinde yöneticiler, onlar için planlanan işlemler sınırında sistemin her noktasına dokunabilmektedirler. Kullanıcı arayüzünün footer kısmında bulunan link aracılığıyla ulaşabildikleri 'Admin Giriş Ekranı' aracılığıyla <b>yöneticiler kendi kullanıcı adı ve şifrelerini girerek admin paneline erişebilirler.</b> Bilgilerini doğru girmedikleri takdirde ekranın sağ üst köşesinde 5 saniye duracak şekilde ayarlanan bir <b>error sweetalert</b> ile bilgilendiriliyorlar. Bilgilerini doğru bir şekilde girdikleri senaryoda ise karşılarına admin paneli Dashboard ekranı çıkmaktadır. Yönetici bu panelde sol menü yardımıyla yapmak istediği işlemleri gerçekleştirebilmektedir. İsterse Kategoriler, Destinasyonlar veya Rezervasyonlar üzerinde <b>CRUD işlemleri</b> yapabilirken isterse de <b>4 adet grafik sayesinde (Line, Bar, Pie ve Doughnut Grafikleri)</b> sistemdeki datalarla hazırlanmış bilgileri görüntüleyebilmektedir. Ayrıca yöneticilere bu panel üzerinden <b>Mesajlaşabilme İmkanı</b> da sunulmuştur.

# Kullanılan Teknolojiler ve Uygulamalar
✅ ASP.NET MVC
<br>
✅ Entity Framework
<br>
✅ Code First
<br>
✅ Microsoft SQL Server (MSSQL) Veritabanı
<br>
✅ HTML-CSS-Bootstrap
<br>
✅ Chart JS ile Line/Bar/Pie/Doughnut Grafikleri
<br>
✅ JS
<br>
✅ LINQ
<br>
✅ Input Alanında Telefon Numarası Maskeleme
<br>
✅ SweetAlert
<br>
✅ 3D Kredi Kartı ile Ödeme Tasarımı (Girilen kart numarasına göre MasterCard ise farklı Visa ise farklı bir arkaplan rengi oluşmaktadır. Ayrıca CVV kodunu yazarken kartın arka yüzü gözükmektedir.)
<br>
✅ Login/Logout İşlemleri
<br>
✅ Pop-Up (Modal) Kullanımı
<br>
✅ Admin Paneli Üzerinden Mesajlaşabilme
<br><br>


# Veritabanı Diyagramı
![veritabani_diyagrami](https://github.com/user-attachments/assets/fae24e29-333f-4623-998a-6e6a890efbdd)

# Kullanıcı Arayüzü
![anasayfa_tamami](https://github.com/user-attachments/assets/41b2d274-5ffc-4d25-96cd-ab1eeebfbfb4)
![tur_detay_sayfasi](https://github.com/user-attachments/assets/667ed385-067f-4eb8-9aaf-ce95c894cb06)
![rezervasyon-popup](https://github.com/user-attachments/assets/49c31049-23e2-46c9-a5be-9508b8dccfec)
![rezervasyon_success_sweetalert](https://github.com/user-attachments/assets/8d9e015d-cc21-4903-98bf-3471bc1201c6)


# Admin Arayüzü
![admin_giris_paneli](https://github.com/user-attachments/assets/0a64e29d-a5b3-42be-b11a-fe7cd02d1172)
![dashboard](https://github.com/user-attachments/assets/0b2d37ef-1724-475e-a5ab-564166d5b332)
![destinasyon_list](https://github.com/user-attachments/assets/6e540303-7a57-4fcb-b9ba-12185c0c9d9a)
![destinasyon_guncelleme](https://github.com/user-attachments/assets/67895567-6bee-4ddc-b781-0b12f4a65522)
![gelen_mesajlar](https://github.com/user-attachments/assets/dc18d9f9-3f38-4187-812a-ab0ea5d0bf98)
![line_grafik](https://github.com/user-attachments/assets/6a03ce6f-df48-40d7-adce-fa82969e307e)
![bar_grafik](https://github.com/user-attachments/assets/4d492256-d5c8-40b4-987c-97a6041948b1)
![pie_grafik](https://github.com/user-attachments/assets/9cb97b90-952d-44e0-a429-c8a927358a4c)
![donut_grafik](https://github.com/user-attachments/assets/702274a6-69e6-4668-be4d-14ddbbeccd1d)
![mastercard](https://github.com/user-attachments/assets/9d2014dc-5ea1-4c89-8356-060355321954)
![visa](https://github.com/user-attachments/assets/2c7e2639-d1dd-4276-ba5a-051bc6b6a25e)
![kredi_karti_cvv_kodu](https://github.com/user-attachments/assets/5a1159f8-45e9-4f64-bfb1-de64d0191d2c)
