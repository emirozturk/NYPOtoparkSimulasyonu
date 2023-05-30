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
        throw new NotImplementedException();
    }

    public void GirisYap(Arac arac)
    {
        throw new NotImplementedException();
    }

    public List<Arac> CikislariYap()
    {
        throw new NotImplementedException();
    }
}