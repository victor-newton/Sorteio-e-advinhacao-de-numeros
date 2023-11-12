// ACERTE O NÚMERO
// Projeto que tem em mente gerar um número aleatória a cada execução,
// e fazer com que o usuário acerte o número que foi gerado através de dicas.

Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 101);

do {
    
    Console.WriteLine("Digite um numero de 1 a 100: ");
    
    int chute = int.Parse(Console.ReadLine());

    if(chute == numeroSecreto){
        Console.WriteLine("Número correto");
        break;
    } else if(chute < numeroSecreto){
        Console.WriteLine("O número secreto é maior");
    } else{
        Console.WriteLine("O número secreto é menor");
    }

}while(true);

Console.WriteLine("O jogo acabou. Você acertou o número secreto!");

