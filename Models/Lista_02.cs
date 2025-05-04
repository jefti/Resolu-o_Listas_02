using System;

public static class Lista_02
{  
    public static void Exercicio01(){
        //Escrever um algoritmo que lê o índice de poluição medido e emite a notificação
        //adequada aos diferentes grupos de empresas.
        double index;

        Console.WriteLine("Informe o indice: ");
        index = Convert.ToDouble(Console.ReadLine());

        if(index >= 0.3){
            Console.WriteLine("");
        }

        if(index >= 0.4){
            Console.WriteLine("");
        }

        if(index >= 0.5){
            Console.WriteLine("");
        }

    }

}