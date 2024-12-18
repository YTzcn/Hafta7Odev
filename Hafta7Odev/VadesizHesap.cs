namespace Hafta7Odev;

internal class VadesizHesap : Hesap
{
    private const decimal IslemUcreti = 5.0m;

    public override void ParaYatir(decimal miktar)
    {
        Bakiye += miktar;
    }

    public override void ParaCek(decimal miktar)
    {
        decimal toplamCekilecek = miktar + IslemUcreti;
        if (Bakiye >= toplamCekilecek)
            Bakiye -= toplamCekilecek;
        else
            throw new InvalidOperationException("Yetersiz bakiye.");
    }
}