using System;

public class Program {
  public static void Main() {
    Console.Write("Digite o valor de A: ");
    int A = int.Parse(Console.ReadLine());
    Console.Write("Digite o valor de B: ");
    int B = int.Parse(Console.ReadLine());

    int C;

    if (A == B) {
      C = A + B;
    } else {
      C = A * B;
    }

    Console.WriteLine("O resultado é: {0}", C);
  }
}