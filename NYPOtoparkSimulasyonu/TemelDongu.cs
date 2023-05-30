namespace NYPOtoparkSimulasyonu;

public class TemelDongu
{
    private Otopark otopark;
    private Kuyruk kuyruk;
    private Config config;
    private int kar;
    private int zarar;
    public TemelDongu(Config config,Otopark otopark,Kuyruk kuyruk)
    {
        this.config = config;
        this.otopark = otopark; 
        this.kuyruk = kuyruk;
    }
    /// <summary>
    /// Döngünün başlamasını sağlar, verilen sürede bekleme yaparak adımları hesaplar
    /// </summary>
    /// <param name="AdimSuresi">Saniye cinsinden adım bekleme süresini ifade eder</param>
    public void Baslat(int AdimSuresi)
    {
        while (true)
        {
            List<Arac> gelenAraclar = RastgeleAracBelirle(config.AdimdaMaxAracSayisi);
            List<Arac> cikanAraclar = otopark.CikislariYap();
            while (gelenAraclar.Count > 0 && otopark.BosYerVarMi())
            {
                otopark.GirisYap(gelenAraclar[0]);
                gelenAraclar.RemoveAt(0);
                kar += config.BirimFiyat;
            }
        
            while (gelenAraclar.Count > 0 && kuyruk.BosYerVarMi())
            {
                kuyruk.GirisYap(gelenAraclar[0]);
                gelenAraclar.RemoveAt(0);
            }

            List<Arac> kuyruktanCikanlar = kuyruk.CikislariYap();
            zarar += gelenAraclar.Count * config.BirimFiyat;
            zarar += kuyruktanCikanlar.Count * config.BirimFiyat;

            DurumGoster();
            
            Thread.Sleep(AdimSuresi*1000);
        }
    }

    private void DurumGoster()
    {
        throw new NotImplementedException();
    }

    private List<Arac> RastgeleAracBelirle(int AdimdaMaxAracSayisi)
    {
        var aracSayisi = new Random().Next(0, AdimdaMaxAracSayisi+1);
        List<Arac> yeniGelenler = new List<Arac>();
        for (int i = 0; i < aracSayisi; i++)
            yeniGelenler.Add(new Arac(config.MaxAracOtoparkSuresi,config.MaxAracKuyrukSuresi));
        return yeniGelenler;
    }
}