namespace Hafta7Odev;

interface IYayinci
{
    void AboneEkle(IAbone abone);
    void AboneCikar(IAbone abone);
    void BildirimGonder(string mesaj);
}