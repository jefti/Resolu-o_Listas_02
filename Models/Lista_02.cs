using System;

public static class Lista_02
{  
    public static void Exercicio01(){

    }

    public static void Exercicio02(){
        double numeroEscrito, maior, menor;
        
        do{
            Console.WriteLine("1. Escreva um numero real (não negativo):"); 
            numeroEscrito = Convert.ToDouble(Console.ReadLine());
        }while(numeroEscrito <= 0);
        
        maior = numeroEscrito;
        menor = numeroEscrito;
        

        for(int i = 2; i <= 5; i++){
            do{
                Console.WriteLine($"{i}. Escreva um numero real (não negativo):"); 
                numeroEscrito = Convert.ToDouble(Console.ReadLine());
            }while(numeroEscrito <= 0);
            

            if(numeroEscrito > maior){
                maior = numeroEscrito;
            }

            if(numeroEscrito < menor){
                menor = numeroEscrito;
            }
        
        }

        Console.WriteLine($"Maior numero: {maior}");
        Console.WriteLine($"Menor numero: {menor}");

    } 

    public static void Exercicio03(){
        double numeroEscrito;

        do{

            Console.WriteLine("Escreva um número:"); 
            numeroEscrito = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha uma opção do menu:");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Mutiplicação");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("0. Sair");
            String opcaoSelecionada = Console.ReadLine();

            Console.WriteLine("\n");
            if(opcaoSelecionada.Equals("0")){
                break;
            }
            
            switch(opcaoSelecionada){
                case "1":
                    for(int i = 1; i <= 10 ; i++){
                        Console.WriteLine(numeroEscrito+" + " + i + " = "+ (numeroEscrito + i));
                    };
                    break;
                case "2":
                    for(int i = 1; i <= 10 ; i++){
                        Console.WriteLine(numeroEscrito+" - " + i + " = "+ (numeroEscrito - i));
                    };
                    break;
                case "3":
                    for(int i = 1; i <= 10 ; i++){
                        Console.WriteLine(numeroEscrito+" * " + i + " = "+ (numeroEscrito * i));
                    };
                    break;
                case "4":
                    for(int i = 1; i <= 10 ; i++){
                        Console.WriteLine(numeroEscrito+" / " + i + " = "+ (numeroEscrito / i));
                    };
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Console.WriteLine("\n");
        } while(true);


        
    }
}