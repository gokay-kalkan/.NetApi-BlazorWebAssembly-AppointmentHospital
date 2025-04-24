AppointmentHospital - Blazor WebAssembly & .NET 8 Hastane Randevu Sistemi
Bu proje, kullanıcıların doktorlar ve poliklinikler üzerinden online randevu almasını sağlayan bir web uygulamasıdır. 
Sistem admin tarafından yönetilirken, kullanıcılar kayıt olabilir, giriş yapabilir ve uygun tarihlerde randevu oluşturabilir.

 Kullanılan Teknolojiler
Backend: ASP.NET Core 8.0 Web API, Entity Framework Core, MSSQL
Frontend: Blazor WebAssembly
Authentication: JWT Bearer Token
Veri Transferi: DTO + AutoMapper
Katmanlar: Api, Shared, Client

Özellikler:

✅ Kullanıcı kayıt ve giriş
✅ JWT ile kimlik doğrulama
✅ Doktor ekleme / düzenleme (Admin panel)
✅ Poliklinik ve randevu yönetimi
✅ Uygun tarihlere randevu oluşturma
✅ Rol bazlı erişim kontrolü
✅ Temiz servis + controller yapısı
✅ Api ve Client tarafı bağımsız olarak ayrıldı

Kullanıcı Rolleri

Rol	Yetkiler
👤 Kullanıcı	Randevu alma, geçmiş randevuları görme
👨‍⚕️ Admin	Doktor ve poliklinik yönetimi, tüm randevulara erişim

______________________________________________________________________________________________
English Version
AppointmentHospital - Blazor WebAssembly & .NET 8 Hospital Appointment System
A full-stack hospital appointment management system allowing users to register, log in, and schedule appointments with doctors via a web interface. The admin panel allows managing doctors and clinics.
Tech Stack
Backend: .NET 8 Web API, EF Core, MSSQL, AutoMapper
Frontend: Blazor WebAssembly
Auth: JWT Token Authentication
Architecture: Layered (API / Client / Shared)

Features:
User registration & login
JWT-based secure API access
Doctor and clinic management (Admin)
Schedule appointments with available doctors
Role-based UI views (User vs Admin)
DTO mapping and clean architecture


