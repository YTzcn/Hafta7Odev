namespace Hafta7Odev;

class Abone : IAbone
{
    public string Ad { get; set; }

    public void BilgiAl(string mesaj)
    {
        Console.WriteLine($"{Ad}, yeni mesaj: {mesaj}");
    }
}