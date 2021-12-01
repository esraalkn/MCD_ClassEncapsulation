using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_ClassEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Kisi ft = new Kisi();
                ft.Adi = "faik";
                ft.DenemeTelNo = "02158874648svdsvs155545ds++++";
                ft.dogumtarihi = new DateTime(1978, 07, 20);
                ft.Soyadi = "turan";
                ft.Yas = 43;
                ft.TelefonNumarasi = "12345678912345678";
                Console.WriteLine(ft.Adi);
                Console.WriteLine(ft.DenemeTelNo);
                Console.WriteLine(ft.dogumtarihi);
                Console.WriteLine(ft.Soyadi);
                Console.WriteLine(ft.Yas);
                Console.WriteLine(ft.TelefonNumarasi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata Oluşru");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
