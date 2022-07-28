using System;

namespace diziler_donguler
{
    class Program
    {
        static void Main(string[] args)
        {

// Dizilerin tanimalanmasi
// dizler index sifiri kullanir.
            string[] renkler = new string[5]; //  string tipinde adi renkler olan  eleman sayisi 5 olan bir dizi tanimaldik
            string[] hayvanlar = { "kedi", "köpek", "kuş", "maymun" }; // burda diziyi tanimalarken elemanlarini da atadik, ayni zamanda boyutuda belirlemis olduk boyututu 4)
            int[] dizi;// burda ilk önce diziyi tanimladik, dizi adinda elemanlari integer yapsinda bir dizi
            dizi = new int[5];// 5 tane elemani olan bir dizi

// dizilere deger atama ve erisim
            renkler[0] = "Mavi"; // yukarda tanimlanan renkler adli dizinin 1. elemanina Mavi rengi atadik
            dizi[3] = 10; // dizinin 4.elmanina 10 olarak deger verdik. 
            Console.WriteLine(hayvanlar[1]); //hayvanlar 2. elemanini getir.
            Console.WriteLine(dizi[3]);// dizinin 4. elemanini getirir. Cikti: köpek
            Console.WriteLine(renkler[0]);//renkler adli dizinin ilk elemani getir .Cikti :mavi

// Döngülerle Dizi Kullanimi
// Örnek: Klavyeden girilen n tane sayinin ortalamasini alan program.
//yapacaklarimiz : bir dizi olusturcaz. bu dizini boyutunada konsoldan gelen veri karar versin. 
//bu n sayisinada konsoldan gelen veri karar veriyor zaten. bu diziye a tamiss oldugumuz degerlerin ortalamasini alacaz.

            Console.WriteLine("Lütfen dizinin eleman sayıdsını giriniz: ");//Kullanicidan bu dizinin boyutunu almamiz lazim.
            int diziUzunluk = int.Parse(Console.ReadLine());// bu artik bizim dizimizin uzunlugu
            int[] sayiDizisi = new int[diziUzunluk];// integer degerlere sahip sayiDizisi adli bir dizi tanimaldik, bu dizinin boyutu biliyoruz, elemenlarini bilmiyoruz
            for (int i = 0; i < diziUzunluk; i++)//bu dizinin elemanlarini konsoldanm yani kullanicidan almak icin for parantez kullanioruz.
            {
                Console.Write("Lütfen {0}. sayısı giriniz", i + 1);// Kullaniciya 1.elemani girin, 2. elemani girini gibi bir yazi cikartiyoruz, index sifirdan basladigi icin i+1 yaziyoruz. 
                sayiDizisi[i] = int.Parse(Console.ReadLine());// kullanicidan aldigimiz degeri  dizimize  atamamiz gerekiyor.atama yapiyoruz.
            }//  bu adimin sonunda for parantez ile dizimizin tüm elemanlarini ögreniyoruz.
            int toplam = 0;// her elemani tek tek topliycamiz bir  integer degiskeni tanimliyoruz.
            foreach (var sayi in sayiDizisi) 
            {
                toplam += sayi;
            }
            Console.WriteLine("Ortalama: " + toplam / diziUzunluk);// burda ortalama degeri konsola yansitiyoruz.
        }
    }
}