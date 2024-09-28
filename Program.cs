// queue ve stack dizileri ile uğraşırken, bu tanımı yapmanız gerekmekteidir
using System.Collections;

// Dizi tanımlanın farklı yollarıda var
// Tanım 1 : Hem tanımlayıp hemde dizi  elemanlarını birlikte vermek


int[] intDizisi = new int[3]{1,2,3};

// Tanım 2 : Hem tanımlayıp hemde dizi elemanlarını  birlikte vermek
// bu tip dizi tanımlamada dizi büyüklüğünü vermezsiniz, girdiğiniz eleman kadar büyüklüğü olur
string[] stringDizi ={"Ali","Mehmet","Hacer","Devin","Apler"};


// Tanım 3  : Bir önceki konularda öğrendiğimiz gibi var keyword kullanılarakta tanımlanabilir.

var boolDizi =new bool[] {true,false,false,false,false};


// Ayrı bir konu : 
// Daha önce derste dizi kopyalama hakında, daha sonra yapacaz dediğimiz kısım 

// yukarıdaki stringDizi isimli diziyi, 15 elemanlı bir başka diziye kopyalayacağım
/*string[] copiedDizi =new string[20];
Array.Copy(stringDizi,3,copiedDizi,8,stringDizi.Length-3);


for(int i=0;i<copiedDizi.Length;i++){
    Console.WriteLine(copiedDizi[i]);

}*/ 

//Queue Dizisi : İçerisinde tutulan değerlerin object olarak tutulduğu bir dizidir.
// Queue kuyruk mantığında çalışır. (Akbil,Pide,Otobüs,Araba yıkama kuyruğu)
Queue queue = new Queue();

//Eleman eklemek için 
queue.Enqueue("Renault");
queue.Enqueue("Mercedes");
queue.Enqueue("Audi");
queue.Enqueue("BMW");
queue.Enqueue("Anadol");
queue.Enqueue("togg");
queue.Enqueue("fiat");
queue.Enqueue("kia");
queue.Enqueue("tesla");
queue.Enqueue("opel");
queue.Enqueue("cerry");
queue.Enqueue("hyundai");
// dizinin içerisine 4 adet eleman yerleştirdik.

// Dizinin boyutunu öğrenelim - Count ile dizinin boyutunu öprenebiliriz.
Console.WriteLine(queue.Count);

// queue koleksiyonu kuyruk mantığında çalışır.
// Peek kuyruktan çıkacak ilk elemanı verir. Ancak ilk elemanı silmez.
//string silinen = queue.Peek().ToString();
//Console.WriteLine(silinen);


 
//string que1 = queue.Dequeue().ToString();
//Console.WriteLine(que1);
// Queue dizisi, First In First Out mantığı çalışır.
// Yani ilk giren ilk çıkar mantığında çalışmaktadır.

// bir döngü kullanarak, queue dizinden, elemanları çıkartalım

int sayi = queue.Count;
for(int i = 0;i<sayi;i++){

    Console.WriteLine("Diziden eleman çıkartmak için enter basınız");
    Console.ReadLine();
    string cikan = queue.Dequeue().ToString();
    Console.WriteLine(cikan);
    Console.WriteLine("Dizinin elaman sayısı : {0}",queue.Count);

}

// Diziler ve koleksiyonlar.
// Diziler ile koleksiyonlar arasında tek fark, koleksiyon tanımlarken başlangıç değeri zorunda değildir.


// Yarın Stack yapısını inceleyeceğiz
// Stack Queue'dan farklı olarak, LIFO yani son giren ilk çıkar prensibinde çalışır.
