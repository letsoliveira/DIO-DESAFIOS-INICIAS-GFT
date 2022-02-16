using System;

namespace DIO_DESAFIOS_GFT
{
    class Program
    {
        static void Main(string[] args)
        {
        //     //DESAFIO 1
        //     Console.WriteLine("Digite o número do mês desejado");  
        //     int mes = int.Parse(Console.ReadLine());
        //     switch (mes) {
        //     case 1:
        //         Console.WriteLine("January");
        //         break;
        //     case 2:
        //         Console.WriteLine("February");
        //         break;
        //     case 3:
        //         Console.WriteLine("March");
        //         break;
        //     case 4:
        //         Console.WriteLine("April");
        //         break;
        //     case 5:
        //         Console.WriteLine("May");
        //         break;
        //     case 6:
        //         Console.WriteLine("June");
        //         break;
        //     case 7:
        //         Console.WriteLine("July");
        //         break;
        //     case 8:
        //         Console.WriteLine("August");
        //         break;            
        //     case 9:
        //         Console.WriteLine("September");
        //         break;
        //     case 10:
        //         Console.WriteLine("October");
        //         break;
        //     case 11:
        //         Console.WriteLine("November");
        //         break;
        //     case 12:
        //         Console.WriteLine("December");
        //         break;    
        //     default:
        //         Console.WriteLine("Digite um número válido de 1 a 12");
        //         break;
        // }
        // Console.ReadLine();

            // //DESAFIO 2
            // Console.WriteLine("Digite um número de 1 a 1000:");       
            // int n = int.Parse(Console.ReadLine());
            // for (int i = 1; i <= n; i++)
            // {
            //     int Quadrado = i * i;
            //     int Cubo = i * i * i;
            //     Console.WriteLine($"{i} {Quadrado} {Cubo}");
            // }


        //DESAFIO 3
            while (true)
            {
            int x = int.Parse(Console.ReadLine());
            int D = x;          
            int soma = 0;
                    if(D == 0)
                    break;
                    else if(D % 2 == 0)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                        soma = soma + D;
                        D = D + 2;                                  
                        }  
                        Console.WriteLine(soma);                                     
                    }
                    else
                    {
                        int D2 = D + 1;                
                        for (int i = 0; i < 5; i++)
                        {
                            soma = soma + D2;                    
                            D2 = D2 + 2;                                    
                        }   
                        Console.WriteLine(soma);                             
                    }
            }
        }
    }
}
