// Jogo de Adição

using System;

//Declaração das Funções

void JogoDeAdivinhação()
{
    //Decalaração das Variáveis

    Random numAleatorio = new Random();
    int numRandom = numAleatorio.Next(1, 101);

    Console.WriteLine(numRandom);

    Console.Write("Adivinhe um número entre 0 a 100, que a I.A pensou: ");
    string numJogador = Console.ReadLine()!;
    int numJogadorNumerico = int.Parse(numJogador);

    //Estrututa de Repetição

    while(numJogadorNumerico != numRandom) 
    {
        //Console.WriteLine("Adivinhe um outro número");
        //numJogador = Console.ReadLine()!;

        if (numJogadorNumerico < numRandom)
        {
            Console.WriteLine("O número é menor");

            Console.WriteLine("Adivinhe um outro número");
            numJogadorNumerico = int.Parse(Console.ReadLine());

        }
        if (numJogadorNumerico > numRandom)
        {
            Console.WriteLine("O número é maior");

            Console.WriteLine("Adivinhe um outro número");
            numJogadorNumerico = int.Parse(Console.ReadLine());
        }
        /*if (numJogadorNumerico == numRandom)
        {
            Console.WriteLine("O Jogo Acabou!");
        }*/

        //Console.WriteLine("O Jogo acabou!");
    }

    Console.WriteLine("O Jogo acabou!");

    //Condições

    /*if (numJogadorNumerico < numRandom)
    {
        Console.WriteLine("O número é menor");
    }
    if (numJogadorNumerico > numRandom)
    {
        Console.WriteLine("O número é maior");
    }
    if (numJogadorNumerico == numRandom)
    {
        Console.WriteLine("O Jogo Acabou!");
    }*/

    //Console.WriteLine(numRandom);




}

JogoDeAdivinhação();
