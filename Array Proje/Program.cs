using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz\nAdmin Girişi 1\nKullanıcı Girişi 2");
            string giris = Console.ReadLine();            
            string[] ürün = { "Kola = 10 TL", "Biskuvi = 3TL", "Çikolata = 2 TL" };
             if (giris == "1")
            {
                Console.WriteLine("Parolayı Giriniz");
                string sifre = "1234";
                string parola = Convert.ToString(Console.ReadLine());
                if (sifre == parola)
                {
                    Console.WriteLine("Kola = 10 TL\", \"Biskuvi = 3TL\", \"Çikolata = 2 TL");
                    Console.WriteLine("Ürün Değiştirme 1\nFiyat Değiştirme 2");
                    if (giris == "1")
                    {

                    }
                    
                }
                else
                {
                    Console.WriteLine("şifre yanlış");
                }
               

            }
            else if (giris == "2")
            {
                Console.WriteLine("Kola = 10 TL\nBiskuvi = 3TL\nÇikolata = 2 TL");
                Console.WriteLine("Lütfen Ürün Adını Giriniiz");
                string ürünler = Console.ReadLine();
                if (ürünler == "kola")
                {
                    Console.WriteLine("Ödenecek Tutar 10 tl dir");
                    int tutar = 10;
                    int para = Convert.ToInt32(Console.ReadLine());
                    if (tutar == para)
                    {
                        Console.WriteLine("Ödemeniz Tamamdır Ürünü Alabilirsiniz");
                    }
                    else if (tutar < para)
                    {
                        para -= tutar;
                        Console.WriteLine("Para Üstü{1}", para);
                    }
                    else
                    {
                        para -= tutar;
                        Console.WriteLine("Paranız Eksik{1}", para);
                    }


                }
                else if (ürünler == "biskuvi")
                {
                    Console.WriteLine("Ödenecek Tutar 3 tl dir");
                    int tutar = 3;
                    int para = Convert.ToInt32(Console.ReadLine());
                    if (tutar == para)
                    {
                        Console.WriteLine("Ödemeniz Tamamdır Ürünü Alabilirsiniz");
                    }
                    else if (tutar < para)
                    {
                        tutar -= para;
                        Console.WriteLine("Para Üstü{1}", para);
                    }
                    else
                    {
                        para -= tutar;
                        Console.WriteLine("Paranız Eksik{1}", para);
                    }
                }
                else if (ürünler == "çikolata")
                {
                    Console.WriteLine("Ödenecek Tutar 2 tl dir");
                    int tutar = 2;
                    int para = Convert.ToInt32(Console.ReadLine());
                    if (tutar == para)
                    {
                        Console.WriteLine("Ödemeniz Tamamdır Ürünü Alabilirsiniz");
                    }
                    else if (tutar < para)
                    {
                        tutar -= para;
                        Console.WriteLine("Para Üstü");
                    }
                    else
                    {
                        para -= tutar;
                        Console.WriteLine("Paranız Eksik");
                    }
                }

            }

            



        }
    }
}
