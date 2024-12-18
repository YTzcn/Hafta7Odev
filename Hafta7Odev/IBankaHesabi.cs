namespace Hafta7Odev;

interface IBankaHesabi
{
    DateTime HesapAcilisTarihi { get; set; }
    void HesapOzeti();
}