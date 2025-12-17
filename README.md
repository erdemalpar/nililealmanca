# DeutschBlitz - Nil Alpar ile Almanca Öğrenme 🇩🇪 🇹🇷

DeutschBlitz, interaktif ve eğlenceli bir Almanca öğrenme platformudur. Flashcardlar, quizler ve oyunlaştırılmış içeriklerle dil öğrenimini keyifli hale getirir. ASP.NET Core MVC mimarisi üzerine modern bir arayüz ile inşa edilmiştir.

<!-- GitHub Demo Button -->
[![Canlı Demo](https://img.shields.io/badge/Canlı%20Demo-Ziyaret%20Et-blue?style=for-the-badge&logo=google-chrome&logoColor=white)](https://erdemalpar.github.io/nililealmanca/)

*(Not: Demo linki örnektir, canlı bir URL ile değiştirilebilir.)*

## 🌟 Özellikler

*   **📚 İnteraktif Dersler:** 31 farklı konuda zenginleştirilmiş ders içerikleri (Günlük konuşma, gramer, kelime bilgisi vb.).
*   **🧠 Akıllı Flashcardlar:** Animasyonlu ve seslendirme özellikli kelime kartları.
*   **📝 Dinamik Quizler:** Her ders sonunda, şıkların her seferinde karıştırıldığı (Randomize) testler.
*   **🔒 Kullanıcı & Admin Paneli:**
    *   Öğrenciler için ders kilit sistemi (Admin tarafından yönetilir).
    *   Admin paneli üzerinden kullanıcı yetkilendirme ve ilerleme takibi.
*   **🏆 Oyunlaştırma:** Puan sistemi, seviyeler ve konfetili kutlamalar!
*   **🎨 Modern Arayüz:** Tailwind CSS ile tasarlanmış, duyarlı (responsive) ve şık tasarım.
*   **🎵 Medya İçerikleri:** Şarkılar ve videolarla desteklenmiş öğrenme materyalleri (Yakında).

## 🛠️ Teknolojiler

*   **Backend:** .NET 9.0 (ASP.NET Core MVC)
*   **Frontend:** Razor Pages, Tailwind CSS, JavaScript
*   **Veri:** JSON tabanlı hafif veri saklama (NoSQL yaklaşımı)
*   **Kütüphaneler:**
    *   `Canvas-Confetti`: Animasyonlar için.
    *   `SweetAlert2`: Modern uyarı kutuları.
    *   `Serilog`: Gelişmiş loglama.

## 🚀 Kurulum ve Çalıştırma

Projeyi yerel ortamınızda çalıştırmak için aşağıdaki adımları izleyin:

1.  **Projeyi Klonlayın:**
    ```bash
    git clone https://github.com/erdemalpar/nililealmanca.git
    cd nililealmanca
    ```

2.  **Bağımlılıkları Yükleyin:**
    ```bash
    dotnet restore
    ```

3.  **Uygulamayı Çalıştırın:**
    ```bash
    dotnet run --project GermanLearningApp.Mvc
    ```

4.  **Tarayıcıda Açın:**
    `http://localhost:5027` adresine gidin.

## 📸 Ekran Görüntüleri

*(Buraya projenizden ekran görüntüleri ekleyebilirsiniz: Ana sayfa, Ders ekranı, Quiz ekranı vb.)*

## 🤝 Katkıda Bulunma

1.  Bu depoyu Fork'layın.
2.  Yeni bir özellik dalı (branch) oluşturun (`git checkout -b ozellik/YeniOzellik`).
3.  Değişikliklerinizi commit edin (`git commit -m 'Yeni özellik eklendi'`).
4.  Dalınızı Push edin (`git push origin ozellik/YeniOzellik`).
5.  Bir Pull Request oluşturun.

## 📝 Lisans

Bu proje MIT Lisansı ile lisanslanmıştır. Detaylar için `LICENSE` dosyasına bakın.

---
**Geliştirici:** Nil Alpar Ekibi
