namespace ödevproje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bakiye = 25000;
            string sifre = "123";

            while (true)
            {
                Console.WriteLine("******* HOŞ GELDİNİZ *******");
                Console.WriteLine("\n" +
                    "Kartlı işlem    1\n" +
                    "Kartsız işlem   2\n");
                string secim = Console.ReadLine();


                if (secim == "1")
                {
                    bool giris = false;
                    int hak = 3;

                    while (hak > 0)
                    {
                        Console.WriteLine("Şifreniz: ");
                        string sfr = Console.ReadLine();

                        if (sfr == sifre)
                        {
                            giris = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Şifre Hatalı!");
                            hak--;
                            Console.WriteLine("Kalan Hakkınız: " + hak);
                        }
                    }

                    if (giris == true)
                    {
                        while (true)
                        {
                            Console.WriteLine("\n******* ANA MENÜ *******");
                            Console.WriteLine("" +"Para Çekme        1\n" + "Para Yatırma      2\n" +"Para Transferi      3\n" +"Eğitim Ödemeleri    4\n" +"Fatura Ödemeleri    5\n" +"Bilgi Güncelleme    6\n" +"Çıkış               0\n" +
                                "Seçiminiz: ");


                            int secimMenu = int.Parse(Console.ReadLine());

                            if (secimMenu == 1)
                            {

                                Console.WriteLine("\nÇekmek istediğiniz miktar: ");
                                double miktar = double.Parse(Console.ReadLine());

                                if (bakiye >= miktar)
                                {
                                    bakiye -= miktar;  
                                    Console.WriteLine("Para Çekiliyor...");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("\nÇekilen Miktar: " + miktar + "TL   Yeni Bakiyeniz: " + bakiye + "TL");
                                }
                                else
                                {
                                    Console.WriteLine("Yetersiz Bakiye!");
                                }

                                Console.WriteLine("\n" +
                                    "Ana Menü   9\n" +
                                    "Çıkış      0\n" );

                                int cevap = int.Parse(Console.ReadLine());

                                if (cevap != 9)
                                {
                                    break;
                                }

                            }
                            else if (secimMenu == 2)
                            {
                                Console.WriteLine("\nYatıralacak Miktar: ");
                                double miktar = double.Parse(Console.ReadLine());

                                bakiye += miktar;

                                Console.WriteLine("\nParanız Yatırılıyor...");
                                Thread.Sleep(1000);

                                Console.WriteLine("Yeni Bakiyeniz: " + bakiye);

                                Console.WriteLine("\n" +
                                    "Ana Menü   9\n" +
                                    "Çıkış      0\n" );
                                int cevap = int.Parse(Console.ReadLine());

                            }
                        }
                    }
                }
            }
        }
    }
}
