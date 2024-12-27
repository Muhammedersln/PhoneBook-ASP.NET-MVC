# Telefon Rehberi Uygulaması

Bu proje, ASP.NET Core MVC kullanılarak geliştirilmiş basit ve kullanıcı dostu bir telefon rehberi uygulamasıdır.

## Özellikler

- 👥 Kişi ekleme, düzenleme, silme ve listeleme işlemleri
- 📱 Telefon numarası ve e-posta doğrulama
- 💾 SQL Server veritabanı desteği
- 🎨 Bootstrap ile modern ve responsive tasarım
- ✨ Kullanıcı dostu arayüz

## Teknolojiler

- ASP.NET Core MVC (.NET 9.0)
- Entity Framework Core
- SQL Server (LocalDB)
- Bootstrap 5
- HTML5 & CSS3

## Kurulum

1. Projeyi klonlayın:
```bash
git clone https://github.com/[kullanıcı-adınız]/PhoneBook-ASP.NET-MVC.git
```

2. Proje dizinine gidin:
```bash
cd PhoneBook-ASP.NET-MVC
```

3. Gerekli NuGet paketlerini yükleyin:
```bash
dotnet restore
```

4. Veritabanını oluşturun:
```bash
dotnet ef database update
```

5. Uygulamayı çalıştırın:
```bash
dotnet run
```

## Kullanım

- Ana sayfada tüm kişilerin listesini görebilirsiniz
- "Yeni Kişi Ekle" butonu ile yeni kayıt oluşturabilirsiniz
- Her kişi için düzenleme ve silme işlemleri yapabilirsiniz
- Zorunlu alanlar: Ad, Soyad ve Telefon Numarası
- İsteğe bağlı alanlar: E-posta ve Adres

## Veritabanı Yapısı

Contacts tablosu aşağıdaki alanları içerir:
- Id (Primary Key)
- FirstName (Ad)
- LastName (Soyad)
- PhoneNumber (Telefon Numarası)
- Email (E-posta)
- Address (Adres)

## Geliştirme

1. Projeyi fork edin
2. Feature branch oluşturun (`git checkout -b feature/amazing-feature`)
3. Değişikliklerinizi commit edin (`git commit -m 'Add some amazing feature'`)
4. Branch'inizi push edin (`git push origin feature/amazing-feature`)
5. Pull Request oluşturun

## Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına bakınız.

## İletişim

[Adınız] - [E-posta adresiniz]

Proje Linki: [https://github.com/[kullanıcı-adınız]/PhoneBook-ASP.NET-MVC](https://github.com/[kullanıcı-adınız]/PhoneBook-ASP.NET-MVC) 