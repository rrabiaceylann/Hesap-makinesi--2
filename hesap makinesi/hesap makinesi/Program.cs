
namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan ilk sayıyı al
            Console.Write("1. sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            // Kullanıcıdan ikinci sayıyı al
            Console.Write("2. sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            // Kullanıcıdan işlem seçmesini iste
            Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
            Console.WriteLine("Toplama için +");
            Console.WriteLine("Çıkarma için -");
            Console.WriteLine("Çarpma için *");
            Console.WriteLine("Bölme için /");
            Console.Write("İşlem: ");
            string islem =Console.ReadLine();

            // İşlemi gerçekleştir
            if (islem == "+")
            {
                int sonuc = sayi1 + sayi2;
                Console.WriteLine("Sonuç: " + sonuc);
            }
            else if (islem == "-")
            {
                int sonuc = sayi1 - sayi2;
                Console.WriteLine("Sonuç: " + sonuc);
            }
            else if (islem == "*")
            {
                int sonuc = sayi1 * sayi2;
                Console.WriteLine("Sonuç: " + sonuc);
            }
            else if (islem == "/")
            {
                // Sıfıra bölme kontrolü
                if (sayi2 != 0)
                {
                    double sonuc = (double)sayi1 / sayi2;
                    Console.WriteLine("Sonuç: " + sonuc);
                }
                else
                {
                    Console.WriteLine("Hata: Bir sayıyı sıfıra bölemezsiniz!");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz işlem seçtiniz.");
            }

            Console.WriteLine("\nDevam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
