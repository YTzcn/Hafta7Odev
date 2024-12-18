namespace Hafta7Odev;

class Kitap : Urun
{
    public string Yazar { get; set; }

    public override decimal HesaplaOdeme()
    {
        return Fiyat * 1.10m;
    }

    public override void BilgiYazdir()
    {
        base.BilgiYazdir();
        Console.WriteLine($"Yazar: {Yazar}, Ödeme: {HesaplaOdeme():C}");
    }
}