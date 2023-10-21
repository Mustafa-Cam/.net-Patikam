// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
           Console.WriteLine("Lütfen 2 sayı girin aralarında boşluk olacak şekilde:(1. sayın senin kaç sayı gireceğindir 2. sayı da girdiğin sayıların 2. sayıya eşit ya da bölünen sayıları almamız için)");
            string? Sayilar = Console.ReadLine();
                string[] twonumber = Sayilar.Split(' '); 
            if(Sayilar!=null){
                Console.WriteLine("1. sayı="+twonumber[0]+" 2.sayı="+twonumber[1]);
            }

            Console.WriteLine("lütfen "+twonumber[0]+" tane sayı giriniz");

            int firstNumber = int.Parse(twonumber[0]); 
            int secondNumber = int.Parse(twonumber[1]); 
                int[] girileceksayilar = new int[firstNumber];

            for (int i = 0; i <firstNumber ; i++)
            {
              girileceksayilar[i] = int.Parse(Console.ReadLine());
            //   Console.WriteLine($"girilen{i+1}.sayı={girileceksayilar[i]}");
            }

              Console.WriteLine($"Sorumuzun cevabı");  
              Console.WriteLine($"------------");  
            for (int i = 0; i < firstNumber ; i++)
            {

                if(girileceksayilar[i]==secondNumber || girileceksayilar[i]%secondNumber == 0){
                    Console.WriteLine($"{girileceksayilar[i]}");
                }
            }
            Console.ReadKey();
        }
    }
}
