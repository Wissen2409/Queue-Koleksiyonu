
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
string[] copiedDizi =new string[20];
Array.Copy(stringDizi,3,copiedDizi,8,stringDizi.Length-3);
for(int i=0;i<copiedDizi.Length;i++){
    Console.WriteLine(copiedDizi[i]);
}