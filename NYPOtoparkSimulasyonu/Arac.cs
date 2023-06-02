namespace NYPOtoparkSimulasyonu;

public class Arac
{
    public string Plaka { get; set; }
    public int OtoparkSuresi { get; set; }
    public int KuyrukSuresi { get; set; }
    public Arac(int MaxAracOtoparkSuresi, int MaxAracKuyrukSuresi)
    {
        OtoparkSuresi = new Random().Next(1,MaxAracOtoparkSuresi);
        KuyrukSuresi = new Random().Next(1,MaxAracKuyrukSuresi);
        Plaka = PlakaOlustur();
    }

    private string PlakaOlustur()
    {
        int ilkKisimSayi = new Random().Next(1, 82);
        string ortaKisim = "";
        for (int i = 0; i < 2; i++)
        {
            int karakterDegeri = new Random().Next(65, 91);
            ortaKisim += (char)karakterDegeri;
        }

        int sonKisim = new Random().Next(1000, 10000);
        string ilkKisim = ilkKisimSayi.ToString().PadLeft(2,'0');
        return $"{ilkKisim} {ortaKisim} {sonKisim}";
    }
}