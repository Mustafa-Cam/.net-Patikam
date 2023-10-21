// See https://aka.ms/new-console-template for more information
namespace HelloWorld{

    class Program
    {

    static void Main(string[] args){
            
    Console.WriteLine("lütfen bir sayı giriniz (kaç tane kelime girmek istiyorsan onun sayısını yaz)");
    int? wordcount = int.Parse(Console.ReadLine());
    if(wordcount!=null){
     Console.WriteLine($"Şimdi {wordcount} tane kelime giriniz") ;
        List<string> wordlist = new List<string>();

        for (int i = 0; i < wordcount; i++)
        {
            wordlist.Add(Console.ReadLine());
            
        }
        wordlist.Reverse();
             Console.WriteLine("");
             Console.WriteLine("Answer => *** ");
            //  Console.WriteLine("----------------");
             Console.WriteLine("");
        foreach (var item in wordlist)
        {
            Console.WriteLine($"{item}"); 
        }   

        } 
        }
        }
        }


