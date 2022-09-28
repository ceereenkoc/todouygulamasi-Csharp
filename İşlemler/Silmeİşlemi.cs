namespace todolist
{
    public class Silmeİşlemi : Veri
    {
        public static void Sil()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız: ");
            string input = Console.ReadLine();

            foreach (var item in kartlar.ToList())
            {
                if (item.başlık == input)
                {
                    kartlar.Remove(item);
                    break;
                }
                else
                {

                    Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için (1)");
                    Console.WriteLine("* Yeniden denemek için (2)");
                    int input1 = Convert.ToInt32(Console.ReadLine());

                    if (input1 == 1)
                    {
                        Console.WriteLine("Çıkış yapılıyor.");
                        break;
                    }
                    else
                    {
                        Sil();
                    }
                }
            }
        }

    }
}