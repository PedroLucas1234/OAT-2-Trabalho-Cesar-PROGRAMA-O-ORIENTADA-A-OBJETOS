using System;
public class Program {
  public static void Main() {
    Console.Write("Digite um número: ");
    int numero = int.Parse(Console.ReadLine());

    int resultado;

    if (numero >= 0) {
      resultado = numero * 2;
    } else {
      resultado = numero * 3;
    }

    // Mostrando o resultado na tela
    Console.WriteLine("O resultado é: {0}", resultado);
  }
}