using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Giraffe

{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Giraffe Academy";
            Console.WriteLine(phrase.Substring(8,3)); // 8.degerden sonra 3 degeri yazdır

            Console.ReadLine();
        }

    }
}
/*1.Clone(): String değişkeni ile oluşturduğumuz içeriğin bir klonunu oluşturarak kopyasını çıkartır.

string metin= "EsmanurKilic";
string cmetin = (string)metin.Clone();
Console.WriteLine(cmetin)

2.Contains(): Metot ile belirtilen karakter veya cümlenin string değişkeni içerisinde var olup olmama durumuna göre kontrol sağlar. Eğer varsa True yoksa False şeklinde geri döndürür.

string metin= "EsmanurKilic";
string cmetin="Kilic;
Console.WriteLine(metin.Contains(cmetin));


3.IndexOf(): String değişkeni içerisinde metot ile belirtilen karakteri arar ve değişkendeki konumunu geri gönderir.

string metin= "EsmanurKilic";
Console.WriteLine(metin.IndexOf('u'));


4.ToLower(): String değişkeni içerisinde ki metnin tüm karakterlerini küçük harf yapar.

string metin= "EsmanurKilic";
Console.WriteLine(metin.ToLower());


5.ToUpper(): String değişkeni içerisinde ki metnin tüm karakterlerini büyük harf yapar.

string metin= "EsmanurKilic";
Console.WriteLine(metin.ToUpper());


6.Insert(): String değişkeni içerisinde ki metnin metot ile belirlenen pozisyonuna ekleme yapar.

string metin= "Esmanur";
string metin2="Kilic";
Console.WriteLine(metin.Insert(7,metin2));


7. Remove(): String değişkeni içeresinde ki metin üzerinde silme işlemleri uygular. İki adet kullanım şekli vardır;

Silinmesi istenen yerin başlangıç indeksi metotta belirtilir ve metinden başlangıç indeksinden sonra ki kısmı silinir.
string metin= "EsmanurKilic";
Console.WriteLine(metin.Remove(7));

string metin= "EsmanurKilic";
Console.WriteLine(metin.Remove(7,3));

8. Replace(): String değişkeni içerisindeki metni veya karakteri başka bir metin veya karakter ile değiştirmek için kullanılır.

string metin= "EsmanurKilic";
Console.WriteLine(metin.Replace("Esmanur", "Kilic"));


9. Split(): String değişkeni içerisindeki metni belirtilen karaktere göre parçalara bölme işlemi yapar.

string metin= "Esmanur,Kilic,1997";
string[] dizi = metin.Split(',');

for (int i = 0; i < dizi.Length; i++)
{
     Console.WriteLine(dizi[i]);
}



10.Trim(): String değişkeni içerisinde ki metnin başlangıcındaki ve bitişindeki boşlukları kaldırır.

string metin= "   EsmanurKilic   ";
Console.WriteLine(metin.Trim());



11.Substring(): String değişkeni içerisinde ki metinden belirli bir bölümü almak için kullanılır. İki adet kullanım şekli vardır;

1.İstenen bölümün başlangıç indeksi metotta belirtilir ve metinden başlangıç indeksinden sonuna kadar olan tüm kısım alınır.

string metin= "EsmanurKilic";
Console.WriteLine(metin.Substring(7));

2.İstenen bölümün başlangıç indeksi ve alınmak istenen karakter sayısı metotta belirtilir ve metinden başlangıç indeksinden başlayarak belirtilen karakter sayısı kadarki kısım alınır.

string metin= "EsmanurKilic";
Console.WriteLine(metin.Substring(7,3));

12.Length;String değişkeni içerisinde ki metnin uzunluğunu geri döndürür.

string metin= "EsmanurKilic ";
Console.WriteLine(metin.Length);


13.PadRight(); String değişkeni içerisindeki metine metotta belirtilen karakteri istenen sayı kadar metinin sağına ekleme işlemi yapar.

string metin= "EsmanurKilic ";
Console.WriteLine(metin.PadRight(14,'a');



14.PadLeft(); String değişkeni içerisindeki metine metotta belirtilen karakteri istenen sayı kadar metinin soluna ekleme işlemi yapar.

string metin= "EsmanurKilic";
Console.WriteLine(metin.PadLeft(14,'a');

 
 */