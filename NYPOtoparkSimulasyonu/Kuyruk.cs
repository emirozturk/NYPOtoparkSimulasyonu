namespace NYPOtoparkSimulasyonu;

public class Kuyruk
{
    private List<Arac> aracListesi;
    private int kuyrukBuyuklugu;

    public Kuyruk(int KuyrukUzunlugu)
    {
        kuyrukBuyuklugu = KuyrukUzunlugu;
        aracListesi = new List<Arac>();
    }

    public bool BosYerVarMi()
    {
        return aracListesi.Count < kuyrukBuyuklugu;
    }

    public void GirisYap(Arac arac)
    {
        aracListesi.Add(arac);
    }

    public List<Arac> CikislariYap()
    {
        List<Arac> cikisYapanAraclar = new List<Arac>();
        for (int i = 0; i < aracListesi.Count; i++)
        {
            aracListesi[i].KuyrukSuresi--;
            if (aracListesi[i].KuyrukSuresi == 0)
            {
                cikisYapanAraclar.Add(aracListesi[i]);
                aracListesi.RemoveAt(i);
                i--;
            }
        }
        return cikisYapanAraclar;
    }

    public void DurumGoster()
    {
        Console.WriteLine("Kuyruk:");
        for (int i = 0; i < kuyrukBuyuklugu; i++)
        {
            if(i<aracListesi.Count)
                Console.Write($" [---{aracListesi[i].Plaka}---] ");
            else
                Console.Write($" [---   BOŞ    ---] ");
        }
        Console.WriteLine();
    }
}