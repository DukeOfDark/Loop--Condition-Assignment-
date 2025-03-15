

class Program
{
    static string ArabaDurumu(int yas)
    {
        if (yas >= 0 && yas < 10)
            return "Arabanız yenidir";
        else if (yas >= 10 && yas < 20)
            return "Servise götürmeniz gerekebilir";
        else if (yas >= 20 && yas < 30)
            return "Arabanız hurdaya çıkma ihtimali var";
        else  
            return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
    }

    static void Main()
    {
        Console.Write("Arabanın yaşını girin: ");
        int yas = int.Parse(Console.ReadLine());
        Console.WriteLine(ArabaDurumu(yas));
    }
}