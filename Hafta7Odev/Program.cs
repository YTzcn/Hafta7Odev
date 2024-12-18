// Banka Hesabı Yönetim Sistemi

namespace Hafta7Odev;

class Program
{
    static void Main()
    {
        // 1. Banka Hesap Testi
        var birikimHesabi = new BirikimHesabi { HesapNo = 12345, FaizOrani = 0.02m };
        var vadesizHesap = new VadesizHesap { HesapNo = 67890 };

        birikimHesabi.ParaYatir(1000);
        vadesizHesap.ParaYatir(500);

        birikimHesabi.ParaCek(200);
        vadesizHesap.ParaCek(100);

        Console.WriteLine($"Birikim Hesabı Bakiye: {birikimHesabi.Bakiye:C}");
        Console.WriteLine($"Vadesiz Hesap Bakiye: {vadesizHesap.Bakiye:C}");

        // 2. Mağaza Yönetim Testi
        List<Urun> urunler = new()
        {
            new Kitap { Ad = "C# Programlama", Fiyat = 50, Yazar = "Ahmet Yılmaz" },
            new Elektronik { Ad = "Kulaklık", Fiyat = 200, Marka = "TechBrand" }
        };

        foreach (var urun in urunler)
        {
            urun.BilgiYazdir();
        }

        // 3. Observer Testi
        var yayinci = new Yayinci();
        var abone1 = new Abone { Ad = "Ali" };
        var abone2 = new Abone { Ad = "Ayşe" };

        yayinci.AboneEkle(abone1);
        yayinci.AboneEkle(abone2);

        yayinci.BildirimGonder("Yeni içerik yayınlandı!");

        yayinci.AboneCikar(abone1);
        yayinci.BildirimGonder("Bir içerik güncellendi!");
    }
}