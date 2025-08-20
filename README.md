# Programa em C# - Entrada de Nomes no Console

## 📌 Descrição
Este programa em **C#** solicita ao usuário que digite **quatro nomes** no console.  
Após a entrada, os nomes podem ser exibidos, armazenados ou utilizados em outras lógicas.

## 🚀 Como funciona
1. O programa pede para digitar o `nome1`.
2. Em seguida, solicita `nome2`, `nome3` e `nome4`.
3. Os nomes são armazenados em variáveis (ou em um array/lista, dependendo da implementação).

## 📂 Estrutura do código (exemplo)
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o nome1");
        string nome1 = Console.ReadLine();

        Console.WriteLine("Digite o nome2");
        string nome2 = Console.ReadLine();

        Console.WriteLine("Digite o nome3");
        string nome3 = Console.ReadLine();

        Console.WriteLine("Digite o nome4");
        string nome4 = Console.ReadLine();

        Console.WriteLine("\nNomes digitados:");
        Console.WriteLine(nome1);
        Console.WriteLine(nome2);
        Console.WriteLine(nome3);
        Console.WriteLine(nome4);
    }
}
