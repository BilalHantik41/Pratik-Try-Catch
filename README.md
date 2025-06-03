## Proje Açıklaması

Bu proje, C# dilinde **Try-Catch** mekanizmasını ve özel istisna sınıflarını uygulayarak farklı hata senaryolarını yakalamayı ve ele almayı amaçlayan bir konsol uygulamasıdır. Aşağıdaki örnekler, kullanıcıdan alınan girdilerin doğrulama kontrolleri ve hata durumlarında nasıl özel mesajlar verileceğini gösterir.

## İçerik ve Yapı

```
Pratik-Try-Catch/
├── Pratik-Try-Catch.sln
├── PratikTryCatch/
│   ├── Program.cs
│   ├── NumberMetod.cs
│   ├── InvalidException.cs
│   ├── MyFormatException.cs
│   └── README.md
└── README.md    ← (Bu dosya)
```

* **PratikTryCatch/**

  * `Program.cs`: Uygulamanın giriş noktası. Kullanıcıdan sayı girmesini isteyip `NumberMetod` sınıfı aracılığıyla gelen değeri işleme sokar.
  * `NumberMetod.cs`: Sayı okuma ve doğrulama işlemlerini yapan sınıf. Boş giriş, sayı dönüşüm hatası ve taşma durumunu kontrol eder.
  * `InvalidException.cs`: Kullanıcının hiçbir değer girmediğinde fırlatılan özel istisna sınıfı.
  * `MyFormatException.cs`: Tam sayıya dönüştürülemeyen girişlerde fırlatılan özel istisna sınıfı.

## Gereksinimler

* .NET 6.0 (veya üzerinde) SDK yüklü olmalıdır.
* Visual Studio 2022 veya daha güncel IDE önerilir; ancak komut satırından `dotnet` CLI kullanılarak da çalıştırabilirsiniz.

## Kurulum ve Çalıştırma

1. Depoyu klonlayın veya indirin:

   ```bash
   git clone https://github.com/BilalHantik41/Pratik-Try-Catch.git
   ```
2. Çözümü derleyin:

   ```bash
   cd Pratik-Try-Catch
   dotnet build
   ```
3. Uygulamayı çalıştırın:

   ```bash
   dotnet run --project PratikTryCatch/PratikTryCatch.csproj
   ```

## Kullanım Örneği

1. Uygulama çalıştığında konsolda aşağıdakine benzer bir mesaj göreceksiniz:

   ```
   Bir Sayı Giriniz:
   ```

2. Aşağıdaki senaryolara göre hata işleme gerçekleşir:

   * **Boş Giriş**

     * Kullanıcı hiçbir şey girip Enter tuşuna bastığında `InvalidException` fırlatılır ve kullanıcıdan tekrar sayı girmesi istenir.
   * **Geçersiz Format**

     * Girilen değer tam sayıya dönüştürülemiyorsa (`int.TryParse` başarısızsa) `MyFormatException` devreye girer ve kullanıcı uyarılır.
   * **Taşma (Overflow) Kontrolü**

     * Girilen sayı `int` sınırlarının dışındaysa `OverflowException` yakalanır ve kullanıcı bilgilendirilir.

3. Geçerli bir sayı girdikten sonra metot döngüden çıkacak ve aşağıdaki gibi sonucu ekrana yazdıracaktır:

   ```
   Girilen sayı: 123
   Bu sayının karesi: 15129
   ```

## Özel İstisna Sınıfları

* **InvalidException** (`InvalidException.cs`)
  Boş ya da yalnızca boşluk karakterlerinden oluşan bir girdi tespit edildiğinde fırlatılır.

  ```csharp
  public class InvalidException : Exception
  {
      public InvalidException(string message) : base(message) { }
  }
  ```

* **MyFormatException** (`MyFormatException.cs`)
  Tam sayıya dönüştürme işlemi başarısız olduğunda fırlatılır.

  ```csharp
  public class MyFormatException : Exception
  {
      public MyFormatException(string message) : base(message) { }
  }
  ```

Bu iki istisna, `NumberMetod` içinde `throw` anahtar kelimesiyle aktif hâle gelerek kullanıcıyı konsolda bilgilendirir.

## Örnek Akış

1. **Konsol**: “Bir Sayı Giriniz: “
2. **Kullanıcı**: `[Enter]`
3. **Program**:

   ```
   [Error] Sayı girmediniz. Lütfen tekrar deneyiniz.
   Bir Sayı Giriniz:
   ```
4. **Kullanıcı**: `abc`
5. **Program**:

   ```
   [Error] Geçerli bir tamsayı formatında bir değer giriniz.
   Bir Sayı Giriniz:
   ```
6. **Kullanıcı**: `9999999999`
7. **Program**:

   ```
   [Error] Girmiş olduğunuz değer çok yüksek veya çok düşük.
   Bir Sayı Giriniz:
   ```
8. **Kullanıcı**: `12`
9. **Program**:

   ```
   Girilen sayı: 12
   Bu sayının karesi: 144
   ```

## Proje Nasıl Geliştirilebilir?

* Ek istisna senaryoları ekleyerek (örneğin negatif sayı kontrolü).
* Farklı hesaplamalar veya farklı veri tipleri için benzer şablonlar oluşturmak.
* İstisna mesajlarını çoklu dil desteğiyle (örneğin İngilizce ve Türkçe) genişletmek.
* UI arayüzüne (örneğin bir Windows Forms ya da WPF uygulamasına) taşıyarak görsel hata mesajları eklemek.

## Lisans

Bu proje MIT Lisansı ile lisanslanmıştır. Ayrıntılar için `LICENSE` dosyasına bakabilirsiniz.

---

Bu README dosyası, **Pratik-Try-Catch** projesindeki kodların ne yaptığı, nasıl çalıştırılacağı ve hangi senaryoları kapsadığına dair ana hatlarıyla bilgi vermektedir. Projeyi daha iyi anlamak ve geliştirmek için kodu inceleyebilir, yeni istisna örnekleri ekleyebilirsiniz.
