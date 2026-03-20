 Proje Açıklaması

Bu projede Unity kullanılarak 2D Bullet Hell türünde bir oyun prototipi geliştirilmiştir. Oyuncu sabit bir noktada durmakta ve mouse ile nişan alarak mermi ateş etmektedir.

- Pool Sistemi Nasıl Çalışıyor

Projede performans optimizasyonu amacıyla Object Pooling sistemi kullanılmıştır. Oyun başında belirli sayıda mermi oluşturularak bir havuzda tutulur. Ateş edildiğinde yeni nesne oluşturmak yerine bu havuzdan mermi alınır. Mermi belirli bir süre sonra devre dışı bırakılarak tekrar havuza geri kazandırılır. Bu sayede sürekli Instantiate ve Destroy işlemleri yapılmaz.

- Spawn Sistemi Nasıl Tasarlandı

Mermi üretimi oyuncu inputuna bağlı olarak çalışmaktadır. Oyuncu mouse sol tuşuna bastığında belirli bir fire rate sınırı ile havuzdan mermi alınarak sahneye yerleştirilir. Bu sistem zaman kontrolü ile dengelenmiştir.

- Kullanılan Asset Kaynakları

Projede görsel olarak basit Unity sprite’ları kullanılmıştır. Herhangi bir dış asset kullanılmamıştır.