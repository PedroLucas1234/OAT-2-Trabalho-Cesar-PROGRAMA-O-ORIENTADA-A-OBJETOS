using System;
public class Program {
  public static void Main() {
    Console.Write("Digite o valor da variável: ");
    int variavel = int.Parse(Console.ReadLine());

    if (variavel % 2 == 0) {
      variavel += 5;
    } else {
      variavel += 8;
    }

    Console.WriteLine("Resultado: " + variavel);
  }
}
