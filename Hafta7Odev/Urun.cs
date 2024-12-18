namespace Hafta7Odev;

abstract class Urun
{
    public string Ad { get; set; }
    public decimal Fiyat { get; set; }

    public abstract decimal HesaplaOdeme();

    public virtual void BilgiYazdir()
    {
        Console.WriteLine($"Ürün: {Ad}, Fiyat: {Fiyat:C}");
    }
}