using System;
using System.Collections.Generic;

namespace konsolUygulama
{


    abstract class Futbolcu
    {
        protected string AdSoyad;
        protected int FormaNo;
        protected double Hiz;
        protected double Dayaniklilik, Pas, Sut, Yetenek, Kararlilik, DogalForm, Sans;
        protected double PasSkor, GolSkor;
        public abstract double PasVer();
        public abstract double GolVurusu();
        public int secim;

        public string EkranaYaz()
        {
            return AdSoyad + " (" + FormaNo + ")";
        }

        public int _Secim
        {
            get
            {
                return secim;
            }
            set
            {
                while (true)
                {
                    if (value == 1)
                    {
                        secim = value;
                        break;
                    }
                    else if (value == 2)
                    {
                        secim = value;
                        break;
                    }
                    
                    else
                    {
                        Console.Write("\n Tekrar Deneyiniz : ");
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
        }
    }
    class Defans : Futbolcu
    {
        Random random1 = new Random();
        private double PozisyonAlma, Kafa, Sicrama;

        public Defans(string adsoyad, int formano)
        {
            this.AdSoyad = adsoyad;
            this.FormaNo = formano;
            this.Hiz = random1.Next(50, 100);
            this.Dayaniklilik = random1.Next(50, 100);
            this.Pas = random1.Next(50, 100);
            this.Sut = random1.Next(50, 100);
            this.Yetenek = random1.Next(50, 100);
            this.Kararlilik = random1.Next(50, 100);
            this.DogalForm = random1.Next(50, 100);
            this.Sans = random1.Next(50, 100);
            this.PozisyonAlma = random1.Next(50, 90);
            this.Kafa = random1.Next(50, 90);
            this.Sicrama = random1.Next(50, 90);
        }

        public override double PasVer()
        {
            this.PasSkor = this.Pas * 0.3 + this.Yetenek * 0.3 + this.Dayaniklilik * 0.1 + this.DogalForm * 0.1 + this.PozisyonAlma * 0.1 + this.Sans * 0.2;
            return this.PasSkor;
        }
        public override double GolVurusu()
        {
            this.GolSkor = this.Yetenek * 0.3 + this.Sut * 0.2 + this.Kararlilik * 0.1 + this.DogalForm * 0.1 + this.Kafa * 0.1 + this.Sicrama * 0.1 + this.Sans * 0.1;
            return this.GolSkor;
        }
    }
    class OrtaSaha : Futbolcu
    {
        Random random1 = new Random();
        private double UzunTop, IlkDokunus, Uretkenlik, TopSurme, OzelYetenek;

        public OrtaSaha(string adsoyad, int formano)
        {
            this.AdSoyad = adsoyad;
            this.FormaNo = formano;
            this.Hiz = random1.Next(50, 100);
            this.Dayaniklilik = random1.Next(50, 100);
            this.Pas = random1.Next(50, 100);
            this.Sut = random1.Next(50, 100);
            this.Yetenek = random1.Next(50, 100);
            this.Kararlilik = random1.Next(50, 100);
            this.DogalForm = random1.Next(50, 100);
            this.Sans = random1.Next(50, 100);
            this.UzunTop = random1.Next(60, 100);
            this.IlkDokunus = random1.Next(60, 100);
            this.Uretkenlik = random1.Next(60, 100);
            this.TopSurme = random1.Next(60, 100);
            this.OzelYetenek = random1.Next(60, 100);
        }
        public override double PasVer()
        {
            this.PasSkor = this.Pas * 0.3 + this.Yetenek * 0.2 + this.OzelYetenek * 0.2 + this.Dayaniklilik * 0.1 + this.DogalForm * 0.1 + this.UzunTop * 0.1 + this.TopSurme * 0.1 + this.Sans * 0.1;
            return this.PasSkor;
        }

        public override double GolVurusu()
        {
            this.GolSkor = this.Yetenek * 0.3 + this.OzelYetenek * 0.2 + this.Sut * 0.2 + this.IlkDokunus * 0.1 + this.Kararlilik * 0.1 + this.DogalForm * 0.1 + this.Sans * 0.1;
            return this.GolSkor;
        }
    }
    class Forvet : Futbolcu
    {
        Random random1 = new Random();
        private double Bitiricilik, IlkDokunus, Kafa, OzelYetenek, SogukKanlilik;



        public Forvet(string adsoyad, int formano)
        {
            this.AdSoyad = adsoyad;
            this.FormaNo = formano;
            this.Hiz = random1.Next(50, 100);
            this.Dayaniklilik = random1.Next(50, 100);
            this.Pas = random1.Next(50, 100);
            this.Sut = random1.Next(50, 100);
            this.Yetenek = random1.Next(50, 100);
            this.Kararlilik = random1.Next(50, 100);
            this.DogalForm = random1.Next(50, 100);
            this.Sans = random1.Next(50, 100);
            this.Bitiricilik = random1.Next(70, 100);
            this.IlkDokunus = random1.Next(70, 100);
            this.Kafa = random1.Next(70, 100);
            this.OzelYetenek = random1.Next(50, 100);
            this.SogukKanlilik = random1.Next(70, 100);
        }
        public override double PasVer()
        {
            this.PasSkor = this.Pas * 0.3 + this.Yetenek * 0.2 + OzelYetenek * 0.2 + this.Dayaniklilik * 0.1 + this.DogalForm * 0.1 + this.Sans * 0.1;
            return this.PasSkor;
        }

        public override double GolVurusu()
        {
            this.GolSkor = this.Yetenek * 0.2 + this.OzelYetenek * 0.2 + this.Sut * 0.1 + this.Kafa * 0.1 + this.IlkDokunus * 0.1 + this.Bitiricilik * 0.1 + this.SogukKanlilik * 0.1 + this.Kararlilik * 0.1 + this.DogalForm * 0.1 + this.Sans * 0.1;
            return this.GolSkor;
        }

    }
    class Program
    {
       

        





        static void Main(string[] args)
        {

            Random rand = new Random();
            List<Futbolcu> takim = new System.Collections.Generic.List<Futbolcu>();
            takim.Add(new Defans("Ryan Donk", 1));
            takim.Add(new Defans("Semih Kaya", 2));
            takim.Add(new Defans("Martin Linnes", 3));
            takim.Add(new Defans("Mariano Filho", 4));
            takim.Add(new OrtaSaha("Fernando Reges", 5));
            takim.Add(new OrtaSaha("Badou Ndiaye", 6));
            takim.Add(new OrtaSaha("Henry Onyekuru", 7));
            takim.Add(new OrtaSaha("Sofiane Feghouli", 8));
            takim.Add(new OrtaSaha("Younes Belhanda", 9));
            takim.Add(new Forvet("Mbaye Diagne", 10));

            while (true)
            {
                int FormaNum;
                int kontrol;
                Console.WriteLine("Rastgele bir oyuncu secildi ");
                FormaNum = rand.Next(1, 10);
                Console.WriteLine(takim[FormaNum].EkranaYaz() + "\n");
                Console.WriteLine("Pas Vermek için herhangi bir tuşa basın");
                Console.ReadLine();
                Console.Clear();
                for (int i = 1; i <= 3; i++)
                {

                    if (takim[FormaNum].PasVer() > 60)
                    {
                        Console.Write("Pas başarılı  : " + takim[FormaNum].EkranaYaz() + " --> ");
                        kontrol = rand.Next(0, 9);
                        while (true)
                        {
                            if (FormaNum != kontrol)
                            {
                                FormaNum = kontrol;
                                break;
                            }
                            else
                            {
                                kontrol = rand.Next(1, 10);
                            }
                        }
                        Console.Write(takim[FormaNum].EkranaYaz() + "\n");
                        Console.ReadLine();
                        if (i == 3)
                        {
                            if (takim[FormaNum].GolVurusu() > 70)
                            {
                                Console.Clear();
                                Console.WriteLine("GOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOL ");

                                Console.WriteLine("Başarılı paslar sonucu Golü Atan Futbolcu =>>   " + takim[FormaNum].EkranaYaz() +" Oluyor" + "\n Devam etmek için tıklayınız.");
                                Console.ReadLine();
                                Console.Clear();

                                Console.WriteLine("Tekrar Oynamak için 1 e tıklayınız.... \n Çıkmak için 2 ye tıklayınız.. ");
                                takim[FormaNum]._Secim = Convert.ToInt32(Console.ReadLine());
                                if (takim[FormaNum]._Secim == 1)
                                {
                                    Console.Clear();
                                    break;
                                }
                                else if (takim[FormaNum]._Secim == 2)
                                {
                                    System.Environment.Exit(0);
                                }
                                else
                                {
                                    Console.WriteLine("Geçersiz Seçim");
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine(" Pozisyon Golle sonuçlanmadı =>> " + takim[FormaNum].EkranaYaz() + " Golü Kaçırdı \n");
                                Console.WriteLine("Tekrar Oynamak için 1 ' e tıklayınız.. \n Çıkmak için 2 ye tıklayınız.. ");
                                takim[FormaNum]._Secim = Convert.ToInt32(Console.ReadLine());
                                if (takim[FormaNum]._Secim == 1)
                                {
                                    Console.Clear();
                                    break;
                                }
                                else if (takim[FormaNum]._Secim == 2)
                                {
                                    System.Environment.Exit(0);
                                }
                                else
                                {
                                    Console.WriteLine("Geçersiz Secim");
                                }

                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Pas başarısız ... ");
                        Console.WriteLine("Hata Yapan Oyuncu -> " + takim[FormaNum].EkranaYaz());
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                }
            }
        }
    }



}
    

