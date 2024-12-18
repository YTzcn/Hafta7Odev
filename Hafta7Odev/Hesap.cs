namespace Hafta7Odev;

public abstract class Hesap
{
    public int HesapNo { get; set; }
    public decimal Bakiye { get; protected set; }

    public abstract void ParaYatir(decimal miktar);
    public abstract void ParaCek(decimal miktar);
}