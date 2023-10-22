// See https://aka.ms/new-console-template for more information
//! Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

namespace HelloWorld{

class Program{

static void Main(string[] args){

 Console.WriteLine("Lütfen bir cümle giriniz");

 string? sentences = Console.ReadLine();

    string[] words = sentences.Split(' ');
        
    if(words.Length>0){
    Console.WriteLine($"{words.Length} tane kelime vardır");
    int count =0;
    
    foreach (var item in words){
        count += item.Length;
        Console.WriteLine($"{item}");
    }
    Console.WriteLine($"{count} tane harf vardır.");
    {
        
    }
    }
    else{
        Console.WriteLine("Hello, World!");
    }
}

}

}
