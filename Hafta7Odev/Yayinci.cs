namespace Hafta7Odev;

class Yayinci : IYayinci
{
    private readonly List<IAbone> aboneler = new();

    public void AboneEkle(IAbone abone)
    {
        aboneler.Add(abone);
    }

    public void AboneCikar(IAbone abone)
    {
        aboneler.Remove(abone);
    }

    public void BildirimGonder(string mesaj)
    {
        foreach (var abone in aboneler)
        {
            abone.BilgiAl(mesaj);
        }
    }
}