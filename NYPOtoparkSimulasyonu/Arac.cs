namespace NYPOtoparkSimulasyonu;

public class Arac
{
    public string Plaka { get; set; }
    public int OtoparkSuresi { get; set; }
    public int KuyrukSuresi { get; set; }
    public Arac(int MaxAracOtoparkSuresi, int MaxAracKuyrukSuresi)
    {
        OtoparkSuresi = MaxAracOtoparkSuresi;
        KuyrukSuresi = MaxAracKuyrukSuresi;
        Plaka = PlakaOlustur();
    }

    private string PlakaOlustur()
    {
        throw new NotImplementedException();
    }
}