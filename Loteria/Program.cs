using System;

namespace Loteria {
    internal class Program {
        static void Main(string[] args) {

            // Solicita ao usuário o número de sorteios desejado
            Console.WriteLine("Seja bem vindo ao gerador de números para apostas na Mega-Sena!");
            Console.WriteLine("O numero minimo permitido para apostas são 6 e o máximo 60.");
            Console.WriteLine("Quantos números você deseja apostar?");
            int QteNum = int.Parse(Console.ReadLine());

            // Verifica se a quantidade solicitada está dentro do intervalo permitido
            while (QteNum < 6 || QteNum > 60) {
                Console.WriteLine("Por favor, escreva um número entre 6 e 60");
                QteNum = int.Parse(Console.ReadLine());
            }

            // Inicializa o array com números de 1 a 60
            int[] numeros = new int[60];
            for (int i = 0; i < 60; i++) {
                numeros[i] = i + 1;
            }

            // Cria uma instância de Random
            Random randNum = new Random();

            // Embaralha os números no array usando o algoritmo de Fisher-Yates
            // para garantir a não repetiçao dos números
            for (int i = numeros.Length - 1; i > 0; i--) {
                int j = randNum.Next(i + 1);
                // Troca o número na posição i com o número na posição j
                int temp = numeros[i];
                numeros[i] = numeros[j];
                numeros[j] = temp;
            }

            // Exibe a quantidade solicitada de números sorteados
            Console.WriteLine($"\nSorteando {QteNum} números:");
            for (int i = 0; i < QteNum; i++) {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}



