using System;
using System.Collections.Generic;

namespace todolist
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine("*****************************************");
            Console.WriteLine("(1) Board listelemek");
            Console.WriteLine("(2) Board'a kart eklemek");
            Console.WriteLine("(3) Board'dan kart silmek");
            Console.WriteLine("(4) Kart taşımak");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                Listelemeİşlemi.Listele();
                break;
                case 2:
                Eklemeİşlemi.Ekle();
                break;
                case 3:
                Silmeİşlemi.Sil();
                break;
                case 4:
                Taşımaİşlemi.Taşı();
                break;
                default:
                Console.WriteLine("Hatalı tuşlama yaptınız.");
                break;
            }
        }
    }
}
