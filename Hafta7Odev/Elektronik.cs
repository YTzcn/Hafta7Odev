namespace Hafta7Odev;

class Elektronik : Urun
{
    public string Marka { get; set; }

    public override decimal HesaplaOdeme()
    {
        return Fiyat * 1.25m;
    }

    public override void BilgiYazdir()
    {
        base.BilgiYazdir();
        Console.WriteLine($"Marka: {Marka}, Ödeme: {HesaplaOdeme():C}");
    }
}