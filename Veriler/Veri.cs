namespace todolist
{
    public class Veri:Kart
    {
        public static List<Kart> kartlar = new List<Kart>();
        public static List<Kişi> kişiler = new List<Kişi>();

        static Veri()
        {
            kişiler = new List<Kişi>()
            {
                new Kişi{id = 1, isim = "Ceren"},
                new Kişi{id = 2, isim = "Kaan"},
                new Kişi{id = 3, isim = "İrem"},
                new Kişi{id = 4, isim = "Meriç"}
            };

            kartlar = new List<Kart>()
            {
                new Kart{başlık = "Ödev" , içerik = "C# ödevi yapılacak", kişi = "Ceren", size = "S", line = "TODO"},
                new Kart{başlık = "Toplantı" , içerik = "28.09.20222-14.30 toplantı yapılacak.", kişi = "İrem", size = "XS", line = "DONE"},
                new Kart{başlık = "Eğitim" , içerik = "OOP videoları izlenecek", kişi = "Kaan", size = "L", line = "INPROGRESS"},
                new Kart{başlık = "Proje" , içerik = "TODO Projesi tamamlanacak", kişi = "Meriç", size = "M", line = "TODO"}
            };
        }
        public static void VeriYaz()
        {
            foreach (var item in kartlar)
            {
                Console.WriteLine(item.başlık+ " " + item.içerik + " " + item.kişi + " " + item.size + " " + item.line);
            }
        }
    }
    
}