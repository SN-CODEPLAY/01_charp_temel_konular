// See https://aka.ms/new-console-template for more information
#region YazdırmaKomutları
Console.WriteLine("Merhaba Dünya");
Console.Write("selam");

Console.WriteLine("************ Yemek Kategorileri **************");
Console.WriteLine();
Console.WriteLine("1-Çorbalar");
Console.WriteLine("2-Ana Yemekler");
Console.WriteLine("3-Soğuk Başlangıçlar");
Console.WriteLine("4-Salatalar");
Console.WriteLine("5-Tatlılar");
Console.WriteLine("6-İçecekler");
Console.WriteLine("************ Yemek Kategorileri **************");
#endregion
#region StringDeğişkenler
//string
//Değişkenin türü, değişken adı
string name = "Sudem";
Console.WriteLine(name);
string customerName;
string customerSurname;
string customerPhone;
string customerEmail, district, city;

customerName = "Ali";
customerSurname = "Çınar";
customerPhone = "+90 500 400 30 20";
customerEmail = "deneme@gmail.com";
district = "Kadıköy";
city = "İstanbul";

Console.WriteLine("************ Rezervasyon Kartı***********");
Console.WriteLine();
Console.WriteLine("---------------------------------------------------------");
Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
Console.WriteLine("İletişim: " + customerPhone);
Console.WriteLine("E-Mail Adresi :  "+ customerEmail);
Console.WriteLine("Adres: " + district + "/" + city);
Console.WriteLine("----------------------------------------------------------");
Console.WriteLine();

customerName = "Ayşe";
customerSurname = "Akyaz";
customerPhone = "+90 600 900 10 90";
customerEmail = "ayseakyaz@gmail.com";
district = "Tuzla";
city = "İstanbul";



Console.WriteLine("---------------------------------------------------------");
Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
Console.WriteLine("İletişim: " + customerPhone);
Console.WriteLine("E-Mail Adresi :  " + customerEmail);
Console.WriteLine("Adres: " + district + "/" + city);
Console.WriteLine("----------------------------------------------------------");




#endregion
#region İntDeğişkenler
//int
int number = 24;
Console.WriteLine(number);

int hamburgerPrice = 300;
int cokePrice = 35;
int waterPrice = 10;
int friesPrice = 50;
int pizzaPrice = 250;
int lemonadePrice = 30;
Console.WriteLine("************ Restoran Menü Fiyatları*************");
Console.WriteLine();
Console.WriteLine("--------- Hamburger: " + hamburgerPrice + "TL");
Console.WriteLine("---------- Pizza : " + pizzaPrice + "TL");
Console.WriteLine("----------Kola :" + cokePrice + "TL");
Console.WriteLine("--------- limonata" + lemonadePrice + "TL");
Console.WriteLine("--------- Kızartma :" + friesPrice + "TL");
Console.WriteLine("--------- Su:      : " + waterPrice+"TL");
Console.WriteLine("************ Restoran Menü Fiyatları*************");

Console.WriteLine();
int hamburgerCount;
int cokeCount;
int waterCount;
int friesCount;
int pizzaCount;
int lemonadeCount;

int totalHamburgerPrice;
int totalcokecount;
int totalwatercount;
int totalfriesCount;
int totalpizzacount;
int totallemonadeCount;

hamburgerCount = 3;
cokeCount = 3;
waterCount = 3;
friesCount = 1;
pizzaCount = 0;
lemonadeCount = 0;
totalHamburgerPrice = hamburgerCount * hamburgerPrice;
totalcokecount = cokeCount * cokePrice;
totalwatercount = waterCount * waterPrice;
totalfriesCount = friesCount * friesPrice;
totalpizzacount = pizzaCount * pizzaPrice;
totallemonadeCount = lemonadeCount * lemonadePrice;
Console.WriteLine("--------------------------------");
Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " " + "TL");
Console.WriteLine("Kola Tutar :" + totalcokecount + "TL");
Console.WriteLine("Su Tutar :" + totalwatercount + "TL");
Console.WriteLine("Kızartma tutarı :" + totalfriesCount + "TL");
Console.WriteLine("Limonata Tutarı : " + totallemonadeCount + "TL");
Console.WriteLine("Pizza Tutarı : " + totalpizzacount + "TL");
Console.WriteLine();
int totalPrice = totalHamburgerPrice+totalcokecount+totalwatercount+totalfriesCount+totalpizzacount+totallemonadeCount;
Console.WriteLine("Toplam Ödenecek tutar" + totalPrice + "TL");
#endregion









Console.ReadLine();