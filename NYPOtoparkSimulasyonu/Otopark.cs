namespace NYPOtoparkSimulasyonu;

public class Otopark
{
    private Arac[,] yerler;
    private int satir;
    private int sutun;
    private int birimFiyat;
    private int katSayisi;

    public Otopark(int Satir,int Sutun, int BirimFiyat)
    {
        satir = Satir;
        sutun = Sutun;
        birimFiyat = BirimFiyat;
        yerler = new Arac[satir, sutun];
    }

    public List<Arac> CikislariYap()
    {
        List<Arac> cikisYapanAraclar = new List<Arac>();
        for(int i=0;i<satir;i++)
        for(int j=0;j<sutun;j++)
            if (yerler[i, j] != null)
            {
                yerler[i, j].OtoparkSuresi--;
                if (yerler[i, j].OtoparkSuresi == 0)
                {
                    cikisYapanAraclar.Add(yerler[i, j]);
                    yerler[i, j] = null;
                }
            }
        return cikisYapanAraclar;
    }

    public bool BosYerVarMi()
    {
        for(int i=0;i<satir;i++)
            for(int j=0;j<sutun;j++)
                if (yerler[i, j] == null)
                    return true;
        return false;
    }

    public void GirisYap(Arac arac)
    {
        for(int i=0;i<satir;i++)
            for(int j=0;j<sutun;j++)
                if (yerler[i, j] == null)
                {
                    yerler[i, j] = arac;
                    return;
                }
    }

    public void DurumGoster()
    {
        for (int i = 0; i < satir; i++)
        {
            for(int j=0;j<sutun;j++)
                if (yerler[i, j] == null)
                    Console.Write($"[-       BOŞ       -]");   
                else
                    Console.Write($"[- {yerler[i,j].Plaka} ({yerler[i,j].OtoparkSuresi,2}) -]");
            Console.WriteLine();            
        }
        Console.WriteLine();        
    }
}