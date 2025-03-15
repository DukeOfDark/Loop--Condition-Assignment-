using ödev_3._2.sınıflar;
class Program
{
    static void Main()
    {
        GenelMudur gm = new GenelMudur();
        Mudur md = new Mudur();
        Programci pr = new Programci();
        Stajyer st = new Stajyer();

        double totalMaas = 0.0;

       
        gm.BilgileriYaz();
        totalMaas += gm.Maas();

        md.BilgileriYaz();
        totalMaas += md.Maas();

        pr.BilgileriYaz();
        totalMaas += pr.Maas();

        st.BilgileriYaz();
        totalMaas += st.Maas();

        Console.WriteLine("Toplam: " + totalMaas + " Birim maaş alıyorlar");
    }
}
