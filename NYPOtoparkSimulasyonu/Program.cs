using NYPOtoparkSimulasyonu;

class OtoparkSimulasyon
{
    public static void Main(String[] args)
    {
        var config = new Config {
            Satir = 5,
            Sutun = 5,
            BirimFiyat = 10,
            KuyrukUzunlugu = 10,
            AdimdaMaxAracSayisi = 5,
            MaxAracOtoparkSuresi = 20,
            MaxAracKuyrukSuresi = 5,
            
        };
        var otopark = new Otopark(config.Satir, config.Sutun, config.BirimFiyat);
        var kuyruk = new Kuyruk(config.KuyrukUzunlugu);
        var dongu = new TemelDongu(config,otopark,kuyruk);
        dongu.Baslat(5);
    }
}