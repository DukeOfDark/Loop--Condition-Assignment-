using ödev3._3.Sınıflar;

{
    Nissan nissan = new Nissan();
    Toyota toyota = new Toyota();
    Suzuki suzuki = new Suzuki();
    Bmw bmw = new Bmw();

    double toplamyakıttuketimi = 0.0;

    toplamyakıttuketimi += nissan.yakit();
    toplamyakıttuketimi += toyota.yakit();
    toplamyakıttuketimi += suzuki.yakit();
    toplamyakıttuketimi += bmw.yakit();
    Console.WriteLine("Toplam: " + toplamyakıttuketimi + "L Tüm Araçlar toplam bu kadar yakıt tüketti");
}