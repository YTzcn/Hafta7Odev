using Hafta7Odev;

public class BirikimHesabi : Hesap
{
    public decimal FaizOrani { get; set; }

    public override void ParaYatir(decimal miktar)
    {
        Bakiye += miktar + (miktar * FaizOrani);
    }

    public override void ParaCek(decimal miktar)
    {
        if (Bakiye >= miktar)
            Bakiye -= miktar;
        else
            throw new InvalidOperationException("Yetersiz bakiye.");
    }
}