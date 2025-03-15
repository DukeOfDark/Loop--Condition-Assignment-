using System;

class Program
{
    static string yassınıfı(int yas)
    {
        if (yas < 0 || yas > 100)
        {
            return "Ya hiç doğmadınız ya da çoktan öldünüz";
        }
        else if (yas <= 18)
        {
            return "Çocuksunuz";
        }
        else if (yas >= 18 && yas <= 35)
        {
            return "Gençsiniz";
        }
        else if (yas >= 35 && yas <= 55)
        {
            return "Yetişkinsiniz";
        }
        else if (yas >= 55 && yas <= 75)
        {
            return "Yaşlısınız";
        }
        else if (yas >= 75 && yas <= 99)
        {
            return "Çok yaşlısınız";
        }
        else
        {
            return "";
        }
    }

    static void Main()
    {
        Console.Write("Yaşınızı girin: ");
        int yas = int.Parse(Console.ReadLine());

        Console.WriteLine(yassınıfı(yas));
    }
}
