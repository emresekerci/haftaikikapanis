//soru 1
/* Console.WriteLine("Merhaba");
Console.WriteLine("Nasılsın");
Console.WriteLine("İyiyim");
Console.WriteLine("Sen nasılsın?"); */


//soru 2
/* string name = "Emre";
int age = 25;

Console.WriteLine(name + " " + age); */

//soru 3
/* Random random = new Random();

//Rastgele sayı üretiyoruz 
int randomNumber = random.Next();
Console.WriteLine("Rastgele Sayı: "+ randomNumber); */

//soru 4
/*
// Rastgele sayı üretir
Random random = new Random();
int randomNumber = random.Next();

//Üretilen rastgele sayının 3 bölümünden kalanı hesaplar
int kalan = randomNumber % 3;

Console.WriteLine("Rastgele sayı: " + randomNumber);
Console.WriteLine("Rastgele sayının 3'e bölümünden kalan: " + kalan); */

//soru 5
/*
Console.WriteLine("Lütfen yaşınızı yazınız: ");
int age = Convert.ToInt32(Console.ReadLine());
if (age >= 18)
{
    Console.WriteLine("+");
    



}
else
{
    Console.WriteLine("-");
}               */

//soru 6

/*

for (int i = 0; i < 10; i++)
{

    Console.WriteLine(" Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}       */

//soru 7
/*
Console.WriteLine("Bir metin giriniz: ");
string firsttxt = Console.ReadLine();
Console.WriteLine("İkinci bir metin giriniz: ");
string secondtxt = Console.ReadLine();

Console.WriteLine("Birinci metin: " + secondtxt);
Console.WriteLine("İkinci metin: " + firsttxt); */

//soru 8

/*
void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma");
}

BenDegerDondurmem();  */

//soru 9

/*
    int sayi1 = 5;
    int sayi2 = 10;
    int toplam = Topla(sayi1, sayi2); 

    Console.WriteLine("Toplam: " + toplam);


static int Topla(int a, int b)
{
    return a + b;
}      */

//soru 10
/*
Console.Write("Lütfen true veya false girin: ");
bool kullaniciGirdisi;

while (!bool.TryParse(Console.ReadLine(), out kullaniciGirdisi))
{
    Console.Write("Geçersiz giriş. Lütfen true veya false girin: ");
}

string sonuc = DegerDondur(kullaniciGirdisi);
Console.WriteLine("Sonuç: " + sonuc);


static string DegerDondur(bool deger)
{
    if (deger)
    {
        return "Kullanıcı true değerini girdi.";
    }
    else
    {
        return "Kullanıcı false değerini girdi.";
    }
}     */

//soru 11
/*
Console.WriteLine("Birinci kişinin yaşını girin:");
int age1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("İkinci kişinin yaşını girin:");
int age2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Üçüncü kişinin yaşını girin:");
int age3 = Convert.ToInt32(Console.ReadLine());

// En yaşlı olan kişinin yaşını bu kod bloğuyla bulabiliriz
int oldest = EnYasli(age1, age2, age3);

// Sonucu ekrana yazdır
Console.WriteLine("En yaşlı kişinin yaşı: " + oldest);
    

    // En yaşlı kişinin yaşını döndüren metot
    static int EnYasli(int age1, int age2, int age3)
{
    int oldest = age1;

    if (age2 > oldest)
    {
        oldest = age2;
    }

    if (age3 > oldest)
    {
        oldest = age3;
    }

    return oldest;
    }   */
//soru 12

/*
int maxNum = 0;
bool firstNum = true;
string input;

Console.WriteLine("Sayıları giriniz: (q tuşu ile en büyük sayıyı görebilirsiniz)");

while (true)
{
    input = Console.ReadLine();

    if (input.ToLower() == "q")
    {
        break;
    }

    try
    {
        int number = Convert.ToInt32(input);

        if (firstNum)
        {
            maxNum = number;
            firstNum = false;
        }
        else
        {
            if (number > maxNum)
            {
                maxNum = number;
            }
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Geçersiz giriş, lütfen bir sayı girin.");
    }
}

if (firstNum)
{
    Console.WriteLine("Hiçbir geçerli sayı girilmedi.");
}
else
{
    Console.WriteLine("En büyük sayı: " + maxNum);
}        */
//soru 13
/*
Console.WriteLine("Birinci ismi giriniz:");
string firstName = Console.ReadLine();

Console.WriteLine("İkinci ismi giriniz:");
string secondName = Console.ReadLine();


SwapName(ref firstName, ref secondName);

// Sonuçları ekrana yazdır
Console.WriteLine("Yer değiştiren isimler: ");
Console.WriteLine("Birinci isim: " + firstName);
Console.WriteLine("İkinci isim: " + secondName);
    

    // İki ismin yerlerini değiştiren metot
    static void SwapName(ref string name1, ref string name2)
{
    string temporary = name1;
    name1 = name2;
    name2 = temporary;
}    */
// soru 14
/*
Console.WriteLine("Bir sayı giriniz:");
string girdi = Console.ReadLine();

int number;
try
{
    
    number = Convert.ToInt32(girdi);

    // Sayının tek mi yoksa çift mi olduğunu belirler
    bool isEven = TekCift(number);

    
    if (isEven)
    {
        Console.WriteLine("Girdiğiniz sayı çift bir sayıdır.");
    }
    else
    {
        Console.WriteLine("Sayı tektir.");
    }
}
catch (FormatException)
{
    Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
}
    

    // Sayının çift olup olmadığını belirleyen metot
    static bool TekCift(int number)
{
    return number % 2 == 0;
}                 */

//soru 15
/*
Console.WriteLine("Hızı girin (km/saat):");
string speedinput = Console.ReadLine();

Console.WriteLine("Zamanı girin (saat):");
string timeinput = Console.ReadLine();

try
{
    double speed = Convert.ToDouble(speedinput);
    double time = Convert.ToDouble(timeinput);

    
    double distance = Calculate(speed, time);

    // Sonucu ekrana yazdır
    Console.WriteLine($"Gidilen yol: {distance} km");
}
catch (FormatException)
{
    Console.WriteLine("Geçersiz giriş. Lütfen geçerli bir sayı girin.");
}
    

    // Yol hesaplayan metot
    static double Calculate(double speed, double time)
{
    return speed * time;
}             */

//soru 16
/*
Console.WriteLine("Dairenin yarıçapını girin:");
string yaricapdeger = Console.ReadLine();

try
{
    
    double yaricap = Convert.ToDouble(yaricapdeger);

    
    double alan = CalculateCircleArea(yaricap);

   
    Console.WriteLine($"Dairenin alanı: {alan:F2} kare birim");
}
catch (FormatException)
{
    Console.WriteLine("Geçersiz giriş. Lütfen geçerli bir sayı girin.");
}
    

    // Dairenin alanını hesaplayan metot
    static double CalculateCircleArea(double yaricap)
{
    return Math.PI * yaricap * yaricap;
}        */
//soru 17
/*
string metin = "Zaman bir GeRi SayIm";

// Cümleyi büyük harflerle yazdır
string metinbuyuk = metin.ToUpper();
Console.WriteLine("Büyük harflerle: " + metinbuyuk);

// Cümleyi küçük harflerle yazdır
string metinkucuk = metin.ToLower();
Console.WriteLine("Küçük harflerle: " + metinkucuk); */


//soru 18
string deger = "    Selamlar   ";

//Trim metodu, metnin başındaki ve sonundaki boşluk karakterlerini kaldırarak yeni bir metin oluşturur.
string degersilme = deger.Trim();

Console.WriteLine("Orijinal metin: [" + deger + "]");
Console.WriteLine("Trimlenmiş metin: [" + degersilme + "]");