using System;

class Agac    // Burada kok ve dugumleri tanitiyoruz
{
    public int Deger;
    public Agac SolDugum;
    public Agac SagDugum;
    
    public Agac(int deger)  //Agac tanimlioyruz
    {
        Deger = deger;
    }
}

class Program
{
    static bool ToplamKontrol(Agac dugum)   
    {
        if (dugum == null) //Gecersiz degereler icin cikti yazdiriyoruz 
        {
            Console.WriteLine("Dikkat: null değerli bir düğümle karşılaşıldı!");
            return false;
        }

        else if (dugum.SolDugum == null && dugum.SagDugum == null)
        {
            // Düğümün çocukları yoksa, düğümün kendisi toplamını temsil eder
            return true;
        }
        else
        {
            // Çocukları olan düğümün alt düğümlerinin toplamını buluyoruz
            int altToplam = 0;
            if (dugum.SolDugum != null)
            {
                altToplam += dugum.SolDugum.Deger;
            }
            if (dugum.SagDugum != null)
            {
                altToplam += dugum.SagDugum.Deger;
            }

            // Alt düğümlerin toplamı düğüm değerine eşit mi diye kontrol ediyoruz
            return dugum.Deger == altToplam && ToplamKontrol(dugum.SolDugum) && ToplamKontrol(dugum.SagDugum);
        }
    }

    static void Main(string[] args)
    {
        // Bir örnek ikili ağaç oluşturalım
        Agac kok = new Agac(12)
        {
            SolDugum = new Agac(5),
            SagDugum = new Agac(7)
        };

        // Toplamı kontrol edelim
        bool sonuc = ToplamKontrol(kok);

        // Sonucu ekrana yazdıralım
        if (sonuc)
        {
            Console.WriteLine("Kok dugumun altindaki dugumlerin toplamidir"); 
        }
        else
        {
            Console.WriteLine("Kok dugumun altindaki dugumlerin toplami degildir.");
        }

        
        Console.ReadKey();
    }
    }

  
