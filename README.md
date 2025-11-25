# 🪙 Coin Catcher & Bomb Dodger Game

Bu proje, programlama yetkinliklerimi geliştirmek amacıyla tasarladığım; kullanıcı girdilerini (klavye hareketleri) anlık işleyen ve dinamik nesne yönetimi içeren bir **yakalama/kaçınma** oyunudur.

## Oynanış Mantığı
- **Avatar:** Kullanıcı tarafından sağa/sola hareket ettirilir.
- **Hedef (Coin):** Yukarıdan rastgele düşen paraları yakalayarak skor artırılır.
- **Tehdit (Bomb):** Aralara gizlenmiş bombalardan kaçınılması gerekir. Temas halinde oyun biter (Game Over).

## Teknik Kazanımlar (Algoritmik Mantık)
Bu oyunun geliştirilme sürecinde şu temel bilgisayar bilimleri konseptleri uygulanmıştır:

- **Collision Detection (Çarpışma Algılama):** Avatarın koordinatları ile düşen nesnenin koordinatlarının çakışıp çakışmadığının matematiksel kontrolü.
- **Random Object Generation:** Paraların ve bombaların düşme sıklığının ve konumunun `Random` fonksiyonları ile belirlenmesi (Olasılık yönetimi).
- **Game Loop:** Oyunun sürekli akmasını ve ekranın güncellenmesini sağlayan döngü yapısı.
- **Input Handling:** Klavye tuşlarına (Sağ/Sol Ok) anlık tepki veren olay dinleyiciler.

## Kullanılan Teknoloji
- **Dil:** [C#]
- **IDE:** Visual Studio

---
*Bu proje, algoritmik düşünme ve gerçek zamanlı sistem kontrolü üzerine yaptığım pratiklerden biridir.*
