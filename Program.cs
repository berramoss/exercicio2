using System;

class exercicio2
{
    static void Main()
    {
        Console.WriteLine("Informe o ano do seu nascimento: ");
        int anonascimento = int.Parse(Console.ReadLine());
        
        int idade = 2024 - anonascimento;
        
        Console.WriteLine($"Sua idade é {idade}");
}
}