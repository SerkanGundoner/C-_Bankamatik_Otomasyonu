using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankamatik_Otomasyon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t\t BANKAMATİK");
            int bakiye = 250;
            string sifre = "ab18";
            Console.WriteLine("Güncel Bakiye= " + bakiye);
            Console.WriteLine("Kartlı İşlem --> 1");
            Console.WriteLine("Kartsız İşlem --> 2");


            bool islemValid = false;
            while (!islemValid)
            {
                string islemString = Console.ReadLine();

                islemValid = int.TryParse(islemString, out int islem);

                if (islem == 1)
                {
                don2:
                    Console.WriteLine("Kart Şifrenizi Giriniz.");
                    
                    string girilensifre = Convert.ToString(Console.ReadLine());
                    if (sifre == girilensifre)

                    {
                    don:
                        Console.WriteLine("\n");
                        Console.WriteLine("Şifre Doğru\n");
                        Console.WriteLine("**********--- Ana Menü ---*********\n");
                        Console.WriteLine("***************");
                        Console.WriteLine("Para Çekmek İçin --> 1");
                        Console.WriteLine("Para Yatırmak İçin --> 2");
                        Console.WriteLine("Para Transferleri İçin --> 3");
                        Console.WriteLine("Eğitim Ödemeleri --> 4");
                        Console.WriteLine("Ödemeler --> 5");
                        Console.WriteLine("Bilgi Güncelleme --> 6");
                        Console.WriteLine("***************");
                        int icislem = Convert.ToInt32(Console.ReadLine());

                        if (icislem == 1)
                        {
                            Console.WriteLine("Lütfen Çekmek İstediğiniz Tutarı Giriniz. ");
                            int cekilecektutar = Convert.ToInt32(Console.ReadLine());
                            if (bakiye < cekilecektutar)
                            {
                                Console.WriteLine("Yeterli Bakiyeniz Bulunmamaktadır \n");
                                Console.WriteLine("Anamenüye Dönmek için --> 9");
                                Console.WriteLine("Çıkış Yapmak için --> 0");
                                int anamenu = Convert.ToInt32(Console.ReadLine());


                                if (anamenu == 9)
                                {
                                    goto don;

                                }
                                else if (anamenu == 0)
                                {
                                    Environment.Exit(0);
                                }
                            }
                            else if (bakiye > cekilecektutar)
                            {
                                bakiye -= cekilecektutar;
                                Console.WriteLine("Güncel Bakiye= " + bakiye + "\n");
                                Console.WriteLine("Anamenüye Dönmek için --> 9");
                                Console.WriteLine("Çıkış Yapmak için --> 0");
                                int anamenu2 = Convert.ToInt32(Console.ReadLine());
                                if (anamenu2 == 9)
                                {
                                    goto don;
                                }
                                else if (anamenu2 == 0)
                                {
                                    Environment.Exit(0);
                                }
                            }
                        }


                        if (icislem == 2)
                        {
                            Console.WriteLine("Kredi Kartına --> 1");
                            Console.WriteLine("Kendi Hesabına Para Yatırmak İçin --> 2 \n");
                            Console.WriteLine("Anamenüye Dönmek için --> 9");
                            Console.WriteLine("Çıkış Yapmak için --> 0");
                            long anamenu = Convert.ToInt64(Console.ReadLine());


                            if (anamenu == 9)
                            {
                                goto don;

                            }
                            else if (anamenu == 0)
                            {
                                Environment.Exit(0);
                            }

                            if (anamenu == 1)
                            {
                                Console.WriteLine("Lütfen 12 haneli Kart Numaranızı Giriniz.");
                                string iban = Console.ReadLine();

                                if (iban.Length == 12)
                                {
                                    Console.WriteLine("Kredi Kartı Borcunuzu Giriniz");
                                    int kredikarti = Convert.ToInt32(Console.ReadLine());
                                    bakiye -= kredikarti;
                                    Console.WriteLine("Güncel Bakiye: " + bakiye + "\n" + " Güncel Kredi Kartı Bakiyeniz: " + kredikarti);
                                }
                                else
                                {
                                    Console.WriteLine("İban Numaranız 12 Haneden Oluşmaktadır");
                                    Console.WriteLine("\n");

                                }

                            }
                            if (anamenu == 2)
                            {
                                Console.WriteLine("Hesaba Yatırmak İstediğiniz Parayı Girin:");
                                int hesabayaticakpara = Convert.ToInt32(Console.ReadLine());
                                bakiye += hesabayaticakpara;
                                Console.WriteLine("Güncel Kredi Kartı Bakiyeniz: " + bakiye);
                            }
                            Console.WriteLine("\n");
                            Console.WriteLine("Anamenüye Dönmek için --> 9");
                            Console.WriteLine("Çıkış Yapmak için --> 0");
                            long anamenu1 = Convert.ToInt64(Console.ReadLine());
                            if (anamenu1 == 9)
                            {
                                goto don;

                            }
                            else if (anamenu1 == 0)
                            {
                                Environment.Exit(0);
                            }
                        }
                        if (icislem == 3)
                        {
                            Console.WriteLine("Başka Hesaba EFT --> 1 ");
                            Console.WriteLine("Başka Hesaba Havale --> 2");
                            int havale = Convert.ToInt32(Console.ReadLine());
                            if (havale == 1)
                            {
                                Console.WriteLine("Lütfen 12 Haneli EFT Numarasını Girin: ");
                                string eft = "TR" + Console.ReadLine();

                                if (eft.Length == 14)
                                {
                                    Console.WriteLine(eft + " EFT Numarası doğru, Yatırmak İstediğiniz Miktarı Girin:");
                                    int miktar = Convert.ToInt32(Console.ReadLine());
                                    bakiye += miktar;
                                    Console.WriteLine("EFT İşleminiz Gerçekleştirilmiştir, Güncel Bakiye: " + bakiye + "TL.");
                                }
                                else
                                {
                                    Console.WriteLine("EFT Numaranız Yanlış");
                                }
                                Console.WriteLine("\n");
                                Console.WriteLine("Anamenüye Dönmek için --> 9");
                                Console.WriteLine("Çıkış Yapmak için --> 0");
                                int eftcikis = Convert.ToInt32(Console.ReadLine());
                                if (eftcikis == 9)
                                {
                                    goto don;
                                }
                                else if (eftcikis == 0)
                                {
                                    Environment.Exit(0);
                                }
                            }
                            if (havale == 2)
                            {
                                Console.WriteLine("Lütfen Havale Numarasını Giriniz: ");
                                string havaleno = Console.ReadLine();
                                if (havaleno.Length == 11)
                                {
                                    Console.WriteLine("Göndermek İstediğiniz Tutarı Girin: ");
                                    int tutar = Convert.ToInt32(Console.ReadLine());
                                    bakiye -= tutar;
                                    Console.WriteLine(tutar + " TL Hesabınızdan Havale Edilmiştir. Güncel Bakiyeniz " + bakiye);
                                    Console.WriteLine("\n");
                                    Console.WriteLine("Anamenüye Dönmek için --> 9");
                                    Console.WriteLine("Çıkış Yapmak için --> 0");
                                    int cikis = Convert.ToInt32(Console.ReadLine());
                                    if (cikis == 9)
                                    {
                                        goto don;
                                    }
                                    else if (cikis == 0)
                                    {
                                        Environment.Exit(0);
                                    }

                                }
                                else if (havaleno.Length != 11)
                                {
                                    Console.WriteLine("Yanlış Havale Numarası");
                                    Console.WriteLine("\n");
                                    Console.WriteLine("Anamenüye Dönmek için --> 9");
                                    Console.WriteLine("Çıkış Yapmak için --> 0");
                                    int cikis = Convert.ToInt32(Console.ReadLine());
                                    if (cikis == 9)
                                    {
                                        goto don;
                                    }
                                    else if (cikis == 0)
                                    {
                                        Environment.Exit(0);
                                    }
                                }
                            }
                        }
                        if (icislem == 4)
                        {
                            Console.WriteLine("Eğitim Ödemeleri Sayfası Arızalı \n");
                            Console.WriteLine("Anamenüye Dönmek için --> 9");
                            Console.WriteLine("Çıkış Yapmak için --> 0");
                            long anamenu1 = Convert.ToInt64(Console.ReadLine());
                            if (anamenu1 == 9)
                            {
                                goto don;
                            }
                            else if (anamenu1 == 0)
                            {
                                Environment.Exit(0);
                            }
                        }
                        if (icislem == 5)
                        {
                            Console.WriteLine("Elektrik Faturası --> 1");
                            Console.WriteLine("Telefon Faturası --> 2");
                            Console.WriteLine("İnternet Faturası --> 3");
                            Console.WriteLine("Su Faturası --> 4");
                            Console.WriteLine("OGS Faturası --> 5");
                            int fatura = 50;
                            fatura = Convert.ToInt32(Console.ReadLine());
                            if (fatura==1 || fatura==2 || fatura == 3 || fatura == 4 || fatura == 5)
                            {
                                bakiye = bakiye - fatura;
                                Console.WriteLine("Fatura tutarı: " + fatura);
                                Console.WriteLine("Güncel bakiye: " + bakiye);                              
                            }
                            else
                            {
                                Console.WriteLine("Yanlış Seçenek \n");
                                Console.WriteLine("Anamenüye Dönmek için --> 9");
                                Console.WriteLine("Çıkış Yapmak için --> 0");
                                int don3 = Convert.ToInt32(Console.ReadLine());
                                if (don3==9)
                                {
                                    goto don2;
                                }
                                else if (don3 == 0)
                                {
                                    Environment.Exit(0);
                                }


                            }
                            
                        }
                        if (icislem == 6)
                        {
                            Console.WriteLine("Şifre Değiştirmek İçin --> 1");
                            int sifredegis = Convert.ToInt32(Console.ReadLine());
                            if (sifredegis == 1)
                            {
                                Console.WriteLine("Eski Şifrenizi Girin: ");
                                sifre = Console.ReadLine();
                                if (sifre == "ab18")
                                {
                                    Console.WriteLine("Yeni Şifrenizi Girin");
                                    string yenisifre = Convert.ToString(Console.ReadLine());
                                    Console.WriteLine("Yeni Şifreyi Tekrar Girin");
                                    string yenisifre2 = Console.ReadLine();
                                    if (yenisifre == yenisifre2)
                                    {

                                        Console.WriteLine("Şifre Değiştirme İşleminiz Gerçekleşmiştir");
                                        sifre = yenisifre;
                                        Console.WriteLine("\n");
                                        Console.WriteLine("Anamenüye Dönmek için --> 9");
                                        Console.WriteLine("Çıkış Yapmak için --> 0");
                                        sifredegis = Convert.ToInt32(Console.ReadLine());



                                        if (sifredegis == 9)
                                        {
                                            goto don2;

                                        }
                                        else if (sifredegis == 0)
                                        {
                                            Environment.Exit(0);
                                        }


                                    }



                                }
                            }
                        }

                    }
                    if (sifre != "ab18")
                    {
                        Console.WriteLine("Şifre Yanlış \n");
                        Console.WriteLine("Anamenüye Dönmek için --> 9");
                        Console.WriteLine("Çıkış Yapmak için --> 0");
                        int anamenu = Convert.ToInt32(Console.ReadLine());


                        if (anamenu == 9)
                        {
                            goto don2;

                        }
                        else if (anamenu == 0)
                        {
                            Environment.Exit(0);
                        }

                    }




                }

                else if (islem == 2)
                {
                don:
                    Console.WriteLine("*******ANA MENÜ*********");
                    Console.WriteLine("Cepbank Para Yatırma --> 1");
                    Console.WriteLine("Para Yatırmak İçin --> 2");
                    Console.WriteLine("Kredi Kartı Ödeme -->3");
                    Console.WriteLine("Eğitim Ödemeleri -->4");
                    Console.WriteLine("Ödemeler --> 3");
                    int icislem2 = Convert.ToInt32(Console.ReadLine());
                    int hak = 3;
                    if (icislem2 == 1)
                    {
                        Console.WriteLine("TC Kimlik No Girin: ");
                        string tc = Console.ReadLine();
                        if (tc.Length == 11)
                        {
                            Console.WriteLine("TC Kimlik No Doğru, Lütfen Cep No Girin (11 Haneli) ");
                            string cepno = Console.ReadLine();
                            if (cepno.Length == 11)
                            {
                                Console.WriteLine((bakiye -= 1000) + " Borcunuz Bulunmaktadır.");

                            }

                            else if (cepno.Length != 11)
                            {
                                Console.WriteLine("Cep No Hatalı!");
                                Console.WriteLine("Anamenüye Dönmek için --> 9");
                                Console.WriteLine("Çıkış Yapmak için --> 0");
                                int cikis4 = Convert.ToInt32(Console.ReadLine());
                                if (cikis4 == 9)
                                {
                                    goto don;
                                }
                                else if (cikis4 == 0)
                                {
                                    Environment.Exit(0);
                                }
                            }
                        }
                        else if (tc.Length != 11)
                        {
                            while (true)
                            {

                                Console.WriteLine("TC Yanlış Kalan Hak " + hak);
                                int girilen = Convert.ToInt32(Console.ReadLine());
                                hak--;
                                if (hak == 0)
                                {
                                    Console.WriteLine(" HAKKINIZ BİTTİ - PROGRAM KİLİTLENİYOR");
                                    break;
                                }
                            }
                        }

                    }
                    if (icislem2 == 2)
                    {
                        Console.WriteLine("Nakit Ödeme --> 1");
                        Console.WriteLine("Hesaptan Ödeme --> 2");
                        Console.WriteLine("Ana Menü --> 9");
                        Console.WriteLine("Çıkış Yapmak İçin --> 0");
                        int sec = Convert.ToInt32(Console.ReadLine());
                        if (sec == 9)
                        {
                            goto don;

                        }
                        else if (sec == 0)
                        {
                            Environment.Exit(0);
                        }
                        if (sec == 1)
                        {
                            Console.WriteLine("Kredi Kartı İçin 12 Haneli Kart Numarası Girin");
                            string kredikarti12 = Convert.ToString(Console.ReadLine());
                            if (kredikarti12.Length == 12)
                            {
                                Console.WriteLine("TC Kimlik No Girin: ");
                                string tc = Console.ReadLine();
                                if (tc.Length == 11)
                                {
                                    Console.WriteLine("Ödeme Miktarını Girin: ");
                                    int tutar = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine(bakiye + " TL Hesabınıza Aktarılmıştır.");
                                    bakiye += tutar;
                                    Console.WriteLine("Güncel Tutar " + bakiye);

                                    Console.WriteLine("Ana Menü --> 9");
                                    Console.WriteLine("Çıkış Yapmak İçin --> 0");
                                    int sec1 = Convert.ToInt32(Console.ReadLine());
                                    if (sec1 == 9)
                                    {
                                        goto don;

                                    }
                                    else if (sec1 == 0)
                                    {
                                        Environment.Exit(0);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("TC Kimlik Hatalı");
                                    Console.WriteLine("\n");
                                    Console.WriteLine("Ana Menü --> 9");
                                    Console.WriteLine("Çıkış Yapmak İçin --> 0");
                                    int sec2 = Convert.ToInt32(Console.ReadLine());
                                    if (sec2 == 9)
                                    {
                                        goto don;

                                    }
                                    else if (sec2 == 0)
                                    {
                                        Environment.Exit(0);
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Kredi Kart numarası Yanlış");
                                Console.WriteLine("\n");
                                Console.WriteLine("Ana Menü --> 9");
                                Console.WriteLine("Çıkış Yapmak İçin --> 0");
                                int sec3 = Convert.ToInt32(Console.ReadLine());
                                if (sec3 == 9)
                                {
                                    goto don;


                                }
                                else if (sec3 == 0)
                                {
                                    Environment.Exit(0);
                                }
                            }
                        }
                        if (sec == 2)
                        {
                            Console.WriteLine("Kredi Kartı İçin 12 Haneli Kart Numarası Girin");
                            string kredikarti12 = Convert.ToString(Console.ReadLine());
                            if (kredikarti12.Length == 12)
                            {
                                Console.WriteLine("Hesap Numaranızı Girin.");
                                string hesapno = Convert.ToString(Console.ReadLine());
                                if (hesapno.Length == 11)
                                {
                                    Console.WriteLine("Yatırmak İstediğiniz Tutarı Girin.");
                                    int tutar = Convert.ToInt32(Console.ReadLine());
                                    bakiye -= tutar;
                                    Console.WriteLine("Güncel Bakiye " + bakiye);
                                    Console.WriteLine("\n");
                                    Console.WriteLine("Ana Menü --> 9");
                                    Console.WriteLine("Çıkış Yapmak İçin --> 0");
                                    int sec4 = Convert.ToInt32(Console.ReadLine());
                                    if (sec4 == 9)
                                    {
                                        goto don;


                                    }
                                    else if (sec4 == 0)
                                    {
                                        Environment.Exit(0);
                                    }
                                }
                            }
                        }

                    }
                    if (icislem2 == 3)
                    {
                        Console.WriteLine("Başka Hesaba EFT  --> 1");
                        Console.WriteLine("Başka Hesaba Havale  --> 2");
                        int transfer = Convert.ToInt32(Console.ReadLine());
                        if (transfer == 1)
                        {

                        }
                        else if (transfer == 2)
                        {
                            Console.WriteLine("11 Haneli Hesap Numaranızı Girin: ");
                            string hesapno = Convert.ToString(Console.ReadLine());
                            if (hesapno.Length == 11)
                            {
                                Console.WriteLine("Göndermek İstediğiniz Miktarı Girin.");
                                int miktar = Convert.ToInt32(Console.ReadLine());
                                bakiye -= miktar;
                                Console.WriteLine("Güncel Bakiye " + bakiye);
                                Console.WriteLine("Transfer Gerçekleşmiştir.");

                            }
                            else
                            {
                                Console.WriteLine("\n");
                                Console.WriteLine("Ana Menü --> 9");
                                Console.WriteLine("Çıkış Yapmak İçin --> 0");
                                int sec5 = Convert.ToInt32(Console.ReadLine());
                                if (sec5 == 9)
                                {
                                    goto don;


                                }
                                else if (sec5 == 0)
                                {
                                    Environment.Exit(0);
                                }
                            }



                        }

                    }
                    if (icislem2 == 4)
                    {
                        Console.WriteLine("Eğitim Ödemeleri Sayfası Arızalı.");
                        Console.WriteLine("\n");
                        Console.WriteLine("Ana Menü --> 9");
                        Console.WriteLine("Çıkış Yapmak İçin --> 0");
                        int sec6 = Convert.ToInt32(Console.ReadLine());
                        if (sec6 == 9)
                        {
                            goto don;


                        }
                        else if (sec6 == 0)
                        {
                            Environment.Exit(0);
                        }
                    }



                }
                else
                {
                    Console.WriteLine("İslem Hatalı");
                    islemValid = false;
                }
            }
            Console.ReadLine();
        }
    }
}
