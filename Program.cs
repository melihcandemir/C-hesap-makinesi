// işelem seçimi
Console.Write("Yapmak istediğiniz işlemi seçiniz\nToplama için: +\nÇıkarma için: -\nBölme için: /\nÇarpma için: x\nMod alma için: mod\nÜs almak için: **\nYüzde almak için: %\nUygulamadan çıkmak için 0'a basınız\nSeciminiz=>> ");
string secim = Console.ReadLine() ?? " ";

// toplama
if (secim == "+") 
{
    Console.WriteLine("Toplama işlemini seçtiniz");
    Console.Write("İlk sayınızı giriniz: ");
    int sa = Convert.ToInt32(Console.ReadLine());
    Console.Write("İkinci sayınızı giriniz: ");
    int sa2 = Convert.ToInt32(Console.ReadLine());
    int sonuc = sa + sa2;
    Console.WriteLine("Toplama sonucu: "+ sonuc);
} 
// çıkarma
else if (secim == "-")
{
    Console.WriteLine("Çıkarma işlemini seçtiniz");
    Console.Write("İlk sayınızı giriniz: ");
    int sa = Convert.ToInt32(Console.ReadLine());
    Console.Write("İkinci sayınızı giriniz: ");
    int sa2 = Convert.ToInt32(Console.ReadLine());
    int sonuc = sa - sa2;
    Console.WriteLine("Çıkarma sonucu: "+ sonuc);
} 
// bölme
else if (secim == "/") 
{
    Console.WriteLine("Bölme işlemini seçtiniz");
    Console.Write("Bölünecek sayınızı giriniz: ");
    int sa = Convert.ToInt32(Console.ReadLine());
    Console.Write("Bölen sayınızı giriniz: ");
    int sa2 = Convert.ToInt32(Console.ReadLine());
    if (sa2 == 0)
    {
        Console.WriteLine("Bölen 0 olamaz!!");
    }
    else 
    {
        int sonuc = sa / sa2;
        Console.WriteLine("Bölüm sonucu: "+ sonuc);
    }
} 
// çarpma
else if (secim == "x")
{
    Console.WriteLine("Çarpma işlemini seçtiniz");
    Console.Write("İlk sayınızı giriniz: ");
    int sa = Convert.ToInt32(Console.ReadLine());
    Console.Write("İkinci sayınızı giriniz: ");
    int sa2 = Convert.ToInt32(Console.ReadLine());
    int sonuc = sa * sa2;
    Console.WriteLine("Çarpma sonucu: "+ sonuc);
}
// mod alma
else if (secim == "mod")
{
    Console.WriteLine("Mod alma işlemini seçtiniz");
    Console.Write("Bölünecek sayınızı giriniz: ");
    int sa = Convert.ToInt32(Console.ReadLine());
    Console.Write("Bölen sayınızı giriniz: ");
    int sa2 = Convert.ToInt32(Console.ReadLine());
    int sonuc = sa % sa2;
    Console.WriteLine("Kalan (mod alma) sonucu: "+ sonuc);
}
// üs alma
else if (secim == "**")
{
    Console.WriteLine("Üs alma işlemini seçtiniz");
    Console.Write("Üssü alınacak sayınızı giriniz: ");
    int sa = Convert.ToInt32(Console.ReadLine());
    Console.Write("Üssü giriniz: ");
    int sa2 = Convert.ToInt32(Console.ReadLine());
    double sonuc = Math.Pow(sa, sa2);
    Console.WriteLine(sa +" üzeri "+sa2+"=>> "+sonuc);
}
// yüzdesin alma
else if (secim == "%")
{
    Console.WriteLine("Yüzde işlemini seçtiniz");
    Console.Write("Yüzdesi alınacak sayınızı giriniz: ");
    var sa = Convert.ToDouble(Console.ReadLine());
    Console.Write("Yüzde ne kadar alınacak giriniz: ");
    var sa2 = Convert.ToDouble(Console.ReadLine());
    if (sa2 == 0)
    {
        Console.WriteLine("Yüzde 0 olamaz!!");
    } 
    else
    {
        var sonuc = (sa / 100) * sa2;
        Console.WriteLine($"{sa} sayısının %{sa2} oranı: {sonuc}");
    }

}
else if (secim == "0")
{
    Console.WriteLine("Uygulamadan çıkış yapılıyor.....");
}
else 
{
    Console.WriteLine("Seçiminiz geçersiz. Çıkış yapılıyor...");
}