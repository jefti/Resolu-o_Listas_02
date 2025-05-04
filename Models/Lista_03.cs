
public static class Lista_03
{  
    public static void exercicio01(){
// Faça um programa que receba do usuário um vetor com 10 posições.
// Em seguida deverá ser impresso 
    // o maior e sua posição 
    // o menor elemento do vetor e sua posição

    
        int maiorNumero, menorNumero, posicaoMaior, posicaoMenor;
        int[] listaNumeros = new int[10];

        
        for(int i = 0; i < 10; i++){
            Console.WriteLine($"Digite o número do indice {i}:");
            int numero = Convert.ToInt32(Console.ReadLine());
            listaNumeros[i] = numero;
        }


        maiorNumero = listaNumeros[0];
        menorNumero = listaNumeros[0];
        posicaoMenor = 0;
        posicaoMaior = 0;

        for(int i = 1; i < listaNumeros.Length; i++){
            if(listaNumeros[i] > maiorNumero){
                maiorNumero = listaNumeros[i];
                posicaoMaior = i;
            }
            if(listaNumeros[i] < menorNumero){
                menorNumero = listaNumeros[i];
                posicaoMenor = i;
            }

        }

    }

}