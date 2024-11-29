using System.Diagnostics.Tracing;

namespace Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hesap Makinesi Console Uygulaması

            string cevap, islem;
            decimal sayi1, sayi2, sonuc = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("############### HESAP MAKİNESİ ###############");
                Console.Write("Sayı Giriniz : ");
                sayi1 = Convert.ToDecimal(Console.ReadLine());

                Console.Write("İşlem Giriniz(+,-,*,/) : ");
                islem = Console.ReadLine();

                Console.Write("Diğer Sayıyı Giriniz : ");
                sayi2 = Convert.ToDecimal(Console.ReadLine());

                switch (islem)
                {
                    case "+":
                        sonuc = sayi1 + sayi2;
                        break;

                    case "-":
                        sonuc = sayi1 - sayi2;
                        break;

                    case "*":
                        sonuc = sayi1 * sayi2;
                        break;

                    case "/":
                        if (sayi2 == 0)
                        {
                            Console.WriteLine("Hata: Sıfıra Bölme İşlemi Yapılamaz.");
                            sonuc = 0;
                        }
                        else
                        {
                            sonuc = sayi1 / sayi2;
                        }
                        break;

                    default:
                        Console.WriteLine("Hatalı İşlem Seçimi Yaptınız");
                        sonuc = 0;
                        break;
                }

                Console.WriteLine("Sonuç : " + sonuc);

                Console.Write("Tekrar İşlem Yapmak İstiyor Musunuz (e/h) :");
                cevap = Console.ReadLine();

            } while (cevap.ToLower() == "e");
        }
    }
}