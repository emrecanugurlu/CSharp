#region ref keywordü nedir? Ne amaçla kullanılır?
//ref keywordü referanstan gelmektedir.
//OOP'de referanslar "=" operatörü ile iletişime geçmektedirler. Bir referans işaretlendiği herhangi bir nesneyi "=" operatörü sayesinde farklı bir referansa işaretleyebilir.
//Değer türlü değişkenlerde referans çalışması yapmak istiyorsak eğer ref keywordü kullanılır.
//ref keywordü değer türlü değişkenlerin referans türlü değişkenler gibi çalışmasını sağlayan bir komuttur.


int b = 6;

ref int a = ref b;

b -= 10;

Console.WriteLine(a);


#endregion
