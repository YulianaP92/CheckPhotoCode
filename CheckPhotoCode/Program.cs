using System;


namespace CheckPhotoCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string photo;//наличие фото
            int month;//срок фото
            string pastePhoto;//вклеено ли фото
            string passport;//использовалось ли фото на паспорт

            Console.WriteLine("Среди документов есть фото? (да/нет)");
            photo = Console.ReadLine();

            if (photo == "да")
            {
                Console.WriteLine("Какое количество месяцев назад сделано фото?");
                month = Convert.ToInt32(Console.ReadLine());
                if (month > 3)
                {
                    Console.WriteLine("Отправить подающего в фотокомнату");
                }
                else
                {
                    Console.WriteLine("Фото использовалось на паспорт? (да/нет)");
                    passport = Console.ReadLine();
                    if (passport == "да")
                    {
                        Console.WriteLine("Отправить подающего в фотокомнату");
                    }
                    else
                    {
                        Console.WriteLine("Фото вклеено? (да/нет)");
                        pastePhoto = Console.ReadLine();
                        if (pastePhoto == "да")
                        {
                            Console.WriteLine("Отправить на оплату");
                        }
                        else
                        {
                            Console.WriteLine("Попросить вклеить фото");
                            Console.WriteLine("Отправить на оплату");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Отправить подающего в фотокомнату");
            }
            Console.ReadKey();
        }       
    }
}

